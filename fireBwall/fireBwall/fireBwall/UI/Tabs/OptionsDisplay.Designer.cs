﻿namespace fireBwall.UI.Tabs
{
    partial class OptionsDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayTrayLogs = new System.Windows.Forms.CheckBox();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxStartMinimized = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.themeBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maxLogsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxPcapBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLoadTheme = new System.Windows.Forms.Button();
            this.buttonLoadModule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTrayLogs
            // 
            this.displayTrayLogs.AutoSize = true;
            this.displayTrayLogs.Checked = true;
            this.displayTrayLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayTrayLogs.Location = new System.Drawing.Point(6, 17);
            this.displayTrayLogs.Name = "displayTrayLogs";
            this.displayTrayLogs.Size = new System.Drawing.Size(123, 17);
            this.displayTrayLogs.TabIndex = 0;
            this.displayTrayLogs.Text = "Display Icon Popups";
            this.displayTrayLogs.UseVisualStyleBackColor = true;
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "--",
            "English",
            "Español",
            "Deutsch",
            "中國",
            "русский",
            "Português",
            "日本語",
            "Français",
            "Italiano",
            "עברית",
            "Nederlands"});
            this.languageBox.Location = new System.Drawing.Point(199, 126);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(204, 21);
            this.languageBox.TabIndex = 1;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(6, 129);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 2;
            this.languageLabel.Text = "Language:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "The Interval must be greater than 9 minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interval in Minutes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Intervaled Checks";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Check on Start Up";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartMinimized
            // 
            this.checkBoxStartMinimized.AutoSize = true;
            this.checkBoxStartMinimized.Checked = true;
            this.checkBoxStartMinimized.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStartMinimized.Location = new System.Drawing.Point(6, 37);
            this.checkBoxStartMinimized.Name = "checkBoxStartMinimized";
            this.checkBoxStartMinimized.Size = new System.Drawing.Size(97, 17);
            this.checkBoxStartMinimized.TabIndex = 9;
            this.checkBoxStartMinimized.Text = "Start Minimized";
            this.checkBoxStartMinimized.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Theme:";
            // 
            // themeBox
            // 
            this.themeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeBox.FormattingEnabled = true;
            this.themeBox.Location = new System.Drawing.Point(199, 153);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(121, 21);
            this.themeBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Edit Current Theme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxLogsBox
            // 
            this.maxLogsBox.Location = new System.Drawing.Point(199, 74);
            this.maxLogsBox.Name = "maxLogsBox";
            this.maxLogsBox.Size = new System.Drawing.Size(204, 20);
            this.maxLogsBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max Logs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max Pcap logs:";
            // 
            // maxPcapBox
            // 
            this.maxPcapBox.Location = new System.Drawing.Point(199, 100);
            this.maxPcapBox.Name = "maxPcapBox";
            this.maxPcapBox.Size = new System.Drawing.Size(204, 20);
            this.maxPcapBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLoadModule);
            this.groupBox2.Controls.Add(this.buttonLoadTheme);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.languageBox);
            this.groupBox2.Controls.Add(this.themeBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.maxPcapBox);
            this.groupBox2.Controls.Add(this.languageLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maxLogsBox);
            this.groupBox2.Controls.Add(this.displayTrayLogs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBoxStartMinimized);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Configuration";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 57);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 415F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 338);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonLoadTheme
            // 
            this.buttonLoadTheme.Location = new System.Drawing.Point(199, 182);
            this.buttonLoadTheme.Name = "buttonLoadTheme";
            this.buttonLoadTheme.Size = new System.Drawing.Size(204, 23);
            this.buttonLoadTheme.TabIndex = 15;
            this.buttonLoadTheme.Text = "buttonLoadTheme";
            this.buttonLoadTheme.UseVisualStyleBackColor = true;
            this.buttonLoadTheme.Click += new System.EventHandler(this.buttonLoadTheme_Click);
            // 
            // buttonLoadModule
            // 
            this.buttonLoadModule.Location = new System.Drawing.Point(9, 182);
            this.buttonLoadModule.Name = "buttonLoadModule";
            this.buttonLoadModule.Size = new System.Drawing.Size(184, 23);
            this.buttonLoadModule.TabIndex = 16;
            this.buttonLoadModule.Text = "buttonLoadModule";
            this.buttonLoadModule.UseVisualStyleBackColor = true;
            this.buttonLoadModule.Click += new System.EventHandler(this.buttonLoadModule_Click);
            // 
            // OptionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "OptionsDisplay";
            this.Size = new System.Drawing.Size(507, 338);
            this.Load += new System.EventHandler(this.OptionsDisplay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox displayTrayLogs;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox checkBoxStartMinimized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox themeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox maxLogsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxPcapBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonLoadModule;
        private System.Windows.Forms.Button buttonLoadTheme;
    }
}
