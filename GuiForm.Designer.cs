namespace Remote_Garden_Control_Gui
{
    partial class GuiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.HumidityTextBox = new System.Windows.Forms.TextBox();
            this.SoilMoistureTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.startButton = new System.Windows.Forms.Button();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.camFeed = new System.Windows.Forms.PictureBox();
            this.ArduinoResetButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.axisDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.measurementComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.APBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.APlabel = new System.Windows.Forms.Label();
            this.SDERNumbericBox = new System.Windows.Forms.NumericUpDown();
            this.SQLSDERlabel = new System.Windows.Forms.Label();
            this.SRRNumbericBox = new System.Windows.Forms.NumericUpDown();
            this.SRRlabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camFeed)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SDERNumbericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRRNumbericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humidity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soil Moisture";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemperatureTextBox.Enabled = false;
            this.TemperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TemperatureTextBox.Location = new System.Drawing.Point(150, 24);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.ReadOnly = true;
            this.TemperatureTextBox.Size = new System.Drawing.Size(67, 26);
            this.TemperatureTextBox.TabIndex = 5;
            this.TemperatureTextBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // HumidityTextBox
            // 
            this.HumidityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HumidityTextBox.Enabled = false;
            this.HumidityTextBox.Location = new System.Drawing.Point(150, 79);
            this.HumidityTextBox.Name = "HumidityTextBox";
            this.HumidityTextBox.ReadOnly = true;
            this.HumidityTextBox.Size = new System.Drawing.Size(67, 26);
            this.HumidityTextBox.TabIndex = 8;
            this.HumidityTextBox.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // SoilMoistureTextbox
            // 
            this.SoilMoistureTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoilMoistureTextbox.Enabled = false;
            this.SoilMoistureTextbox.Location = new System.Drawing.Point(150, 137);
            this.SoilMoistureTextbox.Name = "SoilMoistureTextbox";
            this.SoilMoistureTextbox.ReadOnly = true;
            this.SoilMoistureTextbox.Size = new System.Drawing.Size(67, 26);
            this.SoilMoistureTextbox.TabIndex = 9;
            this.SoilMoistureTextbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 363);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.cameraComboBox);
            this.tabPage1.Controls.Add(this.camFeed);
            this.tabPage1.Controls.Add(this.ArduinoResetButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SoilMoistureTextbox);
            this.tabPage1.Controls.Add(this.HumidityTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TemperatureTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(690, 299);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(67, 26);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(381, 299);
            this.cameraComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(233, 28);
            this.cameraComboBox.TabIndex = 12;
            // 
            // camFeed
            // 
            this.camFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camFeed.Location = new System.Drawing.Point(381, 19);
            this.camFeed.Margin = new System.Windows.Forms.Padding(2);
            this.camFeed.Name = "camFeed";
            this.camFeed.Size = new System.Drawing.Size(376, 276);
            this.camFeed.TabIndex = 11;
            this.camFeed.TabStop = false;
            this.camFeed.Click += new System.EventHandler(this.CamFeed_Click);
            // 
            // ArduinoResetButton
            // 
            this.ArduinoResetButton.Location = new System.Drawing.Point(31, 197);
            this.ArduinoResetButton.Name = "ArduinoResetButton";
            this.ArduinoResetButton.Size = new System.Drawing.Size(186, 31);
            this.ArduinoResetButton.TabIndex = 10;
            this.ArduinoResetButton.Text = "Reset Arduino Connection";
            this.ArduinoResetButton.UseVisualStyleBackColor = true;
            this.ArduinoResetButton.Visible = false;
            this.ArduinoResetButton.Click += new System.EventHandler(this.ArduinoResetButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.axisDisplayComboBox);
            this.tabPage2.Controls.Add(this.endDatePicker);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.startDatePicker);
            this.tabPage2.Controls.Add(this.measurementComboBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historical Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(572, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "X-Axis Display";
            // 
            // axisDisplayComboBox
            // 
            this.axisDisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axisDisplayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.axisDisplayComboBox.FormattingEnabled = true;
            this.axisDisplayComboBox.Items.AddRange(new object[] {
            "All Data",
            "Daily Average"});
            this.axisDisplayComboBox.Location = new System.Drawing.Point(576, 98);
            this.axisDisplayComboBox.Name = "axisDisplayComboBox";
            this.axisDisplayComboBox.Size = new System.Drawing.Size(174, 28);
            this.axisDisplayComboBox.TabIndex = 13;
            this.axisDisplayComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endDatePicker.Location = new System.Drawing.Point(254, 206);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(282, 26);
            this.endDatePicker.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(251, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(251, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startDatePicker.Location = new System.Drawing.Point(254, 96);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(282, 26);
            this.startDatePicker.TabIndex = 9;
            // 
            // measurementComboBox
            // 
            this.measurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.measurementComboBox.FormattingEnabled = true;
            this.measurementComboBox.Items.AddRange(new object[] {
            "Humidity",
            "Soil Moisture",
            "Temperature"});
            this.measurementComboBox.Location = new System.Drawing.Point(39, 94);
            this.measurementComboBox.Name = "measurementComboBox";
            this.measurementComboBox.Size = new System.Drawing.Size(174, 28);
            this.measurementComboBox.Sorted = true;
            this.measurementComboBox.TabIndex = 4;
            this.measurementComboBox.SelectedIndexChanged += new System.EventHandler(this.MeasurementComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(35, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Measurement";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(576, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(801, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Valve Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.APBox);
            this.tabPage4.Controls.Add(this.saveButton);
            this.tabPage4.Controls.Add(this.resetButton);
            this.tabPage4.Controls.Add(this.APlabel);
            this.tabPage4.Controls.Add(this.SDERNumbericBox);
            this.tabPage4.Controls.Add(this.SQLSDERlabel);
            this.tabPage4.Controls.Add(this.SRRNumbericBox);
            this.tabPage4.Controls.Add(this.SRRlabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(801, 330);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Configuration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // APBox
            // 
            this.APBox.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.APBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.APBox.FormattingEnabled = true;
            this.APBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.APBox.Location = new System.Drawing.Point(356, 150);
            this.APBox.Name = "APBox";
            this.APBox.Size = new System.Drawing.Size(91, 28);
            this.APBox.Sorted = true;
            this.APBox.TabIndex = 22;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(79, 210);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 57);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resetButton.Location = new System.Drawing.Point(288, 210);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(134, 57);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // APlabel
            // 
            this.APlabel.AutoSize = true;
            this.APlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.APlabel.Location = new System.Drawing.Point(44, 153);
            this.APlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.APlabel.Name = "APlabel";
            this.APlabel.Size = new System.Drawing.Size(101, 20);
            this.APlabel.TabIndex = 17;
            this.APlabel.Text = "Arduino Port:";
            // 
            // SDERNumbericBox
            // 
            this.SDERNumbericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SDERNumbericBox.Location = new System.Drawing.Point(356, 87);
            this.SDERNumbericBox.Margin = new System.Windows.Forms.Padding(2);
            this.SDERNumbericBox.Maximum = new decimal(new int[] {
            10080,
            0,
            0,
            0});
            this.SDERNumbericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SDERNumbericBox.Name = "SDERNumbericBox";
            this.SDERNumbericBox.Size = new System.Drawing.Size(90, 26);
            this.SDERNumbericBox.TabIndex = 16;
            this.SDERNumbericBox.ThousandsSeparator = true;
            this.SDERNumbericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SQLSDERlabel
            // 
            this.SQLSDERlabel.AutoSize = true;
            this.SQLSDERlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SQLSDERlabel.Location = new System.Drawing.Point(44, 89);
            this.SQLSDERlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SQLSDERlabel.Name = "SQLSDERlabel";
            this.SQLSDERlabel.Size = new System.Drawing.Size(248, 20);
            this.SQLSDERlabel.TabIndex = 15;
            this.SQLSDERlabel.Text = "Server Data Entry Rate (Minutes):";
            this.SQLSDERlabel.Click += new System.EventHandler(this.SQLSDERlabel_Click);
            // 
            // SRRNumbericBox
            // 
            this.SRRNumbericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SRRNumbericBox.Location = new System.Drawing.Point(356, 27);
            this.SRRNumbericBox.Margin = new System.Windows.Forms.Padding(2);
            this.SRRNumbericBox.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.SRRNumbericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SRRNumbericBox.Name = "SRRNumbericBox";
            this.SRRNumbericBox.Size = new System.Drawing.Size(90, 26);
            this.SRRNumbericBox.TabIndex = 14;
            this.SRRNumbericBox.ThousandsSeparator = true;
            this.SRRNumbericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SRRlabel
            // 
            this.SRRlabel.AutoSize = true;
            this.SRRlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SRRlabel.Location = new System.Drawing.Point(44, 29);
            this.SRRlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SRRlabel.Name = "SRRlabel";
            this.SRRlabel.Size = new System.Drawing.Size(255, 20);
            this.SRRlabel.TabIndex = 13;
            this.SRRlabel.Text = "Statistics Refresh Rate (Seconds):";
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 395);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GuiForm";
            this.Text = "Remote Garden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camFeed)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SDERNumbericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRRNumbericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HumidityTextBox;
        private System.Windows.Forms.TextBox SoilMoistureTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox measurementComboBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.Button ArduinoResetButton;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox axisDisplayComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label APlabel;
        private System.Windows.Forms.NumericUpDown SDERNumbericBox;
        private System.Windows.Forms.Label SQLSDERlabel;
        private System.Windows.Forms.NumericUpDown SRRNumbericBox;
        private System.Windows.Forms.Label SRRlabel;
        private System.Windows.Forms.ComboBox APBox;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.PictureBox camFeed;
        private System.Windows.Forms.Button startButton;
    }
}

