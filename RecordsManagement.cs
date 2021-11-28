using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Remote_Garden_Control_Gui
{    
    class RecordKeeper
    {
        private Timer guiTimer;
        private Timer recordTimer;
        private int recordTimerLength; // ms
        private int guiTimerLength; // ms
        Connector arduino;

        public event EventHandler<ArduinoData> InfoUpdate;
        public event EventHandler<ArduinoData> GuiUpdate;
        public event EventHandler<EventArgs> ArduinoConnectionError;

        public RecordKeeper(Connector connector, int recordTimeMinutes, int guiTimeSeconds)
        {
            this.arduino = connector;
            // Need to convert timer lengths to miliseconds.
            recordTimerLength = recordTimeMinutes * 60 * 1000;
            guiTimerLength = guiTimeSeconds * 1000;
        }

        protected virtual void OnRecordUpdate()
        {
            if (InfoUpdate != null)
            {
                ArduinoData newData = arduino.requestGardenData();
                if (newData != null)
                    InfoUpdate(this, newData);
            }
        }
        protected virtual void OnGuiUpdate()
        {
            if (GuiUpdate != null)
            {
                guiTimer.Enabled = false;
                ArduinoData newData = arduino.requestGardenData();
                if (newData != null)
                {
                    GuiUpdate(this, newData);
                    guiTimer.Enabled = true;
                }
            }
        }
        protected virtual void OnArduinoConnectionError()
        {
            if (ArduinoConnectionError != null)
            {
                ArduinoConnectionError(this, new EventArgs());
            }
        }

        public virtual void OnResetArduino(object source, EventArgs args)
        {
            if (arduino.checkConnectionStatus())
            {
                startTimers();
            }
            else
            {
                OnArduinoConnectionError();
            }
        }

        public void OnConfigChanged(object source, ConfigValues args)
        {
            // Both timer values need to be converted to miliseconds.
            guiTimerLength = args.statisticsRefreshRate * 1000;
            recordTimerLength = args.serverDataRate * 60 * 1000;
        }

        public void startTimers()
        {
            if (arduino.checkConnectionStatus())
            {
                recordTimer = new Timer();
                recordTimer.Interval = recordTimerLength;
                recordTimer.Tick += new EventHandler(this.OnTimerFinished);
                recordTimer.Enabled = true;
                guiTimer = new Timer();
                guiTimer.Interval = guiTimerLength;
                guiTimer.Tick += new EventHandler(this.OnTimerFinished);
                guiTimer.Enabled = true;
            }
            else
            {
                OnArduinoConnectionError();
            }
        }

        private void OnTimerFinished(object source, EventArgs args)
        {
            if (source == recordTimer)
                OnRecordUpdate();
            else if (source == guiTimer)
                OnGuiUpdate();
            else
                throw new Exception("Unknown source object sent to OnTimerFinished function.");   
        }
    }

    class RecordRetriever
    {
        SQLServer server;
        public RecordRetriever(SQLServer server)
        {
            this.server = server;
        }

        public void OnGenerateGraphPressed(object sender, RecordRetrievalConfiguration args)
        {
            Chart dataChart = new Chart();
            dataChart.Series.Clear();
            dataChart.Dock = DockStyle.Fill;
            dataChart.Location = new Point(0, 50);

            Series graphData = server.retriveGardenData(args);
            graphData.Name = args.measurement;
            graphData.Color = Color.Green;
            graphData.IsVisibleInLegend = false;
            graphData.IsXValueIndexed = true;
            graphData.ChartType = SeriesChartType.Line;
            dataChart.Series.Add(graphData);

            ChartArea chartArea1 = new ChartArea();
            chartArea1.Name = args.measurement;
            dataChart.ChartAreas.Add(chartArea1);

            Form graphForm = new Form();
            graphForm.SuspendLayout();
            graphForm.AutoScaleMode = AutoScaleMode.Font;
            graphForm.Width = 800;
            graphForm.Height = 600;
            graphForm.Controls.Add(dataChart);
            graphForm.ResumeLayout();
            graphForm.ShowDialog();
        }
    }
}
