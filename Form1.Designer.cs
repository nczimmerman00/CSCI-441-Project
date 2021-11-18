namespace Remote_Garden_Control_Gui
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphMaxBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.autoMaxCheckBox = new System.Windows.Forms.CheckBox();
            this.measurementComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphMaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
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
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humidity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soil Moisture";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemperatureTextBox.Enabled = false;
            this.TemperatureTextBox.Location = new System.Drawing.Point(135, 22);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.ReadOnly = true;
            this.TemperatureTextBox.Size = new System.Drawing.Size(67, 20);
            this.TemperatureTextBox.TabIndex = 5;
            this.TemperatureTextBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // HumidityTextBox
            // 
            this.HumidityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HumidityTextBox.Enabled = false;
            this.HumidityTextBox.Location = new System.Drawing.Point(135, 79);
            this.HumidityTextBox.Name = "HumidityTextBox";
            this.HumidityTextBox.ReadOnly = true;
            this.HumidityTextBox.Size = new System.Drawing.Size(67, 20);
            this.HumidityTextBox.TabIndex = 8;
            this.HumidityTextBox.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // SoilMoistureTextbox
            // 
            this.SoilMoistureTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoilMoistureTextbox.Enabled = false;
            this.SoilMoistureTextbox.Location = new System.Drawing.Point(135, 136);
            this.SoilMoistureTextbox.Name = "SoilMoistureTextbox";
            this.SoilMoistureTextbox.ReadOnly = true;
            this.SoilMoistureTextbox.Size = new System.Drawing.Size(67, 20);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 217);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SoilMoistureTextbox);
            this.tabPage1.Controls.Add(this.HumidityTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TemperatureTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphMaxBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.autoMaxCheckBox);
            this.tabPage2.Controls.Add(this.measurementComboBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.timeComboBox);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historical Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // graphMaxBox
            // 
            this.graphMaxBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.graphMaxBox.Location = new System.Drawing.Point(387, 56);
            this.graphMaxBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.graphMaxBox.Name = "graphMaxBox";
            this.graphMaxBox.Size = new System.Drawing.Size(71, 20);
            this.graphMaxBox.TabIndex = 8;
            this.graphMaxBox.ValueChanged += new System.EventHandler(this.GraphMaxBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Graph Max";
            // 
            // autoMaxCheckBox
            // 
            this.autoMaxCheckBox.AutoSize = true;
            this.autoMaxCheckBox.Location = new System.Drawing.Point(387, 92);
            this.autoMaxCheckBox.Name = "autoMaxCheckBox";
            this.autoMaxCheckBox.Size = new System.Drawing.Size(71, 17);
            this.autoMaxCheckBox.TabIndex = 5;
            this.autoMaxCheckBox.Text = "Auto Max";
            this.autoMaxCheckBox.UseVisualStyleBackColor = true;
            this.autoMaxCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // measurementComboBox
            // 
            this.measurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementComboBox.FormattingEnabled = true;
            this.measurementComboBox.Items.AddRange(new object[] {
            "Humidity",
            "Soil Moisture",
            "Temperature"});
            this.measurementComboBox.Location = new System.Drawing.Point(76, 56);
            this.measurementComboBox.Name = "measurementComboBox";
            this.measurementComboBox.Size = new System.Drawing.Size(121, 21);
            this.measurementComboBox.Sorted = true;
            this.measurementComboBox.TabIndex = 4;
            this.measurementComboBox.SelectedIndexChanged += new System.EventHandler(this.MeasurementComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Measurement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time Period";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month"});
            this.timeComboBox.Location = new System.Drawing.Point(232, 56);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(121, 21);
            this.timeComboBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(588, 191);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Valve Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(588, 191);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Configuration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 249);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Remote Garden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphMaxBox)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.ComboBox measurementComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown graphMaxBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox autoMaxCheckBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox TemperatureTextBox;
    }
}

