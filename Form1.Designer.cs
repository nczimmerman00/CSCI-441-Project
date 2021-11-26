
namespace Form1
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
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SQLSDERlabel = new System.Windows.Forms.Label();
            this.APlabel = new System.Windows.Forms.Label();
            this.SQLSHNlabel = new System.Windows.Forms.Label();
            this.APTextBox = new System.Windows.Forms.TextBox();
            this.SHNTextBox = new System.Windows.Forms.TextBox();
            this.SRRNumbericBox = new System.Windows.Forms.NumericUpDown();
            this.SDERNumbericBox = new System.Windows.Forms.NumericUpDown();
            this.SRRlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SRRNumbericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDERNumbericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(76, 335);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(295, 75);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(436, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(295, 75);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SQLSDERlabel
            // 
            this.SQLSDERlabel.AutoSize = true;
            this.SQLSDERlabel.Location = new System.Drawing.Point(133, 159);
            this.SQLSDERlabel.Name = "SQLSDERlabel";
            this.SQLSDERlabel.Size = new System.Drawing.Size(254, 17);
            this.SQLSDERlabel.TabIndex = 3;
            this.SQLSDERlabel.Text = "SQL Server Data Entry Rate (Minutes):";
            // 
            // APlabel
            // 
            this.APlabel.AutoSize = true;
            this.APlabel.Location = new System.Drawing.Point(133, 216);
            this.APlabel.Name = "APlabel";
            this.APlabel.Size = new System.Drawing.Size(91, 17);
            this.APlabel.TabIndex = 4;
            this.APlabel.Text = "Arduino Port:";
            // 
            // SQLSHNlabel
            // 
            this.SQLSHNlabel.AutoSize = true;
            this.SQLSHNlabel.Location = new System.Drawing.Point(133, 271);
            this.SQLSHNlabel.Name = "SQLSHNlabel";
            this.SQLSHNlabel.Size = new System.Drawing.Size(160, 17);
            this.SQLSHNlabel.TabIndex = 5;
            this.SQLSHNlabel.Text = "SQL Server Host Name:";
            // 
            // APTextBox
            // 
            this.APTextBox.Location = new System.Drawing.Point(517, 216);
            this.APTextBox.Name = "APTextBox";
            this.APTextBox.Size = new System.Drawing.Size(120, 22);
            this.APTextBox.TabIndex = 8;
            // 
            // SHNTextBox
            // 
            this.SHNTextBox.Location = new System.Drawing.Point(517, 271);
            this.SHNTextBox.Name = "SHNTextBox";
            this.SHNTextBox.Size = new System.Drawing.Size(120, 22);
            this.SHNTextBox.TabIndex = 9;
            // 
            // SRRNumbericBox
            // 
            this.SRRNumbericBox.Location = new System.Drawing.Point(517, 100);
            this.SRRNumbericBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SRRNumbericBox.Name = "SRRNumbericBox";
            this.SRRNumbericBox.Size = new System.Drawing.Size(120, 22);
            this.SRRNumbericBox.TabIndex = 10;
            // 
            // SDERNumbericBox
            // 
            this.SDERNumbericBox.Location = new System.Drawing.Point(517, 159);
            this.SDERNumbericBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SDERNumbericBox.Name = "SDERNumbericBox";
            this.SDERNumbericBox.Size = new System.Drawing.Size(120, 22);
            this.SDERNumbericBox.TabIndex = 11;
            // 
            // SRRlabel
            // 
            this.SRRlabel.AutoSize = true;
            this.SRRlabel.Location = new System.Drawing.Point(133, 100);
            this.SRRlabel.Name = "SRRlabel";
            this.SRRlabel.Size = new System.Drawing.Size(225, 17);
            this.SRRlabel.TabIndex = 12;
            this.SRRlabel.Text = "Statistics Refresh Rate (Seconds):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SRRlabel);
            this.Controls.Add(this.SDERNumbericBox);
            this.Controls.Add(this.SRRNumbericBox);
            this.Controls.Add(this.SHNTextBox);
            this.Controls.Add(this.APTextBox);
            this.Controls.Add(this.SQLSHNlabel);
            this.Controls.Add(this.APlabel);
            this.Controls.Add(this.SQLSDERlabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SRRNumbericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDERNumbericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label SQLSDERlabel;
        private System.Windows.Forms.Label APlabel;
        private System.Windows.Forms.Label SQLSHNlabel;
        private System.Windows.Forms.TextBox APTextBox;
        private System.Windows.Forms.TextBox SHNTextBox;
        private System.Windows.Forms.NumericUpDown SRRNumbericBox;
        private System.Windows.Forms.NumericUpDown SDERNumbericBox;
        private System.Windows.Forms.Label SRRlabel;
    }
}

