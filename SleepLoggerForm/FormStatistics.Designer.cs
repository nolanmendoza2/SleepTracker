﻿namespace SleepLoggerForm
{
    partial class FormStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.labelStatistics = new System.Windows.Forms.Label();
            this.richTextBoxSleepRecords = new System.Windows.Forms.RichTextBox();
            this.labelLastRecord = new System.Windows.Forms.Label();
            this.labelWorstRecord = new System.Windows.Forms.Label();
            this.labelBestRecord = new System.Windows.Forms.Label();
            this.labelValueLastRecord = new System.Windows.Forms.Label();
            this.labelValueWorstRecord = new System.Windows.Forms.Label();
            this.labelValueBestRecord = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.labelAverageTimeAsleep = new System.Windows.Forms.Label();
            this.labelValueAverageTimeAsleep = new System.Windows.Forms.Label();
            this.labelAverageBedtime = new System.Windows.Forms.Label();
            this.labelValueAverageBedtime = new System.Windows.Forms.Label();
            this.labelAverageWakeTime = new System.Windows.Forms.Label();
            this.labelValueAverageWakeTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatistics
            // 
            this.labelStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatistics.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatistics.Location = new System.Drawing.Point(12, 9);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(674, 28);
            this.labelStatistics.TabIndex = 0;
            this.labelStatistics.Text = "Sleep Statistics";
            this.labelStatistics.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBoxSleepRecords
            // 
            this.richTextBoxSleepRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxSleepRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxSleepRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSleepRecords.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxSleepRecords.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxSleepRecords.Location = new System.Drawing.Point(7, 75);
            this.richTextBoxSleepRecords.Name = "richTextBoxSleepRecords";
            this.richTextBoxSleepRecords.ReadOnly = true;
            this.richTextBoxSleepRecords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxSleepRecords.Size = new System.Drawing.Size(300, 344);
            this.richTextBoxSleepRecords.TabIndex = 1;
            this.richTextBoxSleepRecords.Text = "";
            this.richTextBoxSleepRecords.WordWrap = false;
            // 
            // labelLastRecord
            // 
            this.labelLastRecord.AutoSize = true;
            this.labelLastRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastRecord.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLastRecord.Location = new System.Drawing.Point(313, 60);
            this.labelLastRecord.Name = "labelLastRecord";
            this.labelLastRecord.Size = new System.Drawing.Size(75, 15);
            this.labelLastRecord.TabIndex = 2;
            this.labelLastRecord.Text = "Last Record:";
            // 
            // labelWorstRecord
            // 
            this.labelWorstRecord.AutoSize = true;
            this.labelWorstRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWorstRecord.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelWorstRecord.Location = new System.Drawing.Point(313, 112);
            this.labelWorstRecord.Name = "labelWorstRecord";
            this.labelWorstRecord.Size = new System.Drawing.Size(87, 15);
            this.labelWorstRecord.TabIndex = 3;
            this.labelWorstRecord.Text = "Worst Record:";
            // 
            // labelBestRecord
            // 
            this.labelBestRecord.AutoSize = true;
            this.labelBestRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBestRecord.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelBestRecord.Location = new System.Drawing.Point(313, 166);
            this.labelBestRecord.Name = "labelBestRecord";
            this.labelBestRecord.Size = new System.Drawing.Size(78, 15);
            this.labelBestRecord.TabIndex = 4;
            this.labelBestRecord.Text = "Best Record:";
            // 
            // labelValueLastRecord
            // 
            this.labelValueLastRecord.AutoSize = true;
            this.labelValueLastRecord.Location = new System.Drawing.Point(313, 75);
            this.labelValueLastRecord.Name = "labelValueLastRecord";
            this.labelValueLastRecord.Size = new System.Drawing.Size(0, 15);
            this.labelValueLastRecord.TabIndex = 5;
            // 
            // labelValueWorstRecord
            // 
            this.labelValueWorstRecord.AutoSize = true;
            this.labelValueWorstRecord.Location = new System.Drawing.Point(313, 127);
            this.labelValueWorstRecord.Name = "labelValueWorstRecord";
            this.labelValueWorstRecord.Size = new System.Drawing.Size(0, 15);
            this.labelValueWorstRecord.TabIndex = 6;
            // 
            // labelValueBestRecord
            // 
            this.labelValueBestRecord.AutoSize = true;
            this.labelValueBestRecord.Location = new System.Drawing.Point(313, 181);
            this.labelValueBestRecord.Name = "labelValueBestRecord";
            this.labelValueBestRecord.Size = new System.Drawing.Size(0, 15);
            this.labelValueBestRecord.TabIndex = 7;
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecords.Location = new System.Drawing.Point(7, 60);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(55, 15);
            this.labelRecords.TabIndex = 8;
            this.labelRecords.Text = "Records:";
            // 
            // labelAverageTimeAsleep
            // 
            this.labelAverageTimeAsleep.AutoSize = true;
            this.labelAverageTimeAsleep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAverageTimeAsleep.Location = new System.Drawing.Point(313, 208);
            this.labelAverageTimeAsleep.Name = "labelAverageTimeAsleep";
            this.labelAverageTimeAsleep.Size = new System.Drawing.Size(128, 15);
            this.labelAverageTimeAsleep.TabIndex = 9;
            this.labelAverageTimeAsleep.Text = "Average Time Asleep:";
            // 
            // labelValueAverageTimeAsleep
            // 
            this.labelValueAverageTimeAsleep.AutoSize = true;
            this.labelValueAverageTimeAsleep.Location = new System.Drawing.Point(313, 223);
            this.labelValueAverageTimeAsleep.Name = "labelValueAverageTimeAsleep";
            this.labelValueAverageTimeAsleep.Size = new System.Drawing.Size(73, 15);
            this.labelValueAverageTimeAsleep.TabIndex = 10;
            this.labelValueAverageTimeAsleep.Text = "awdawdawd";
            // 
            // labelAverageBedtime
            // 
            this.labelAverageBedtime.AutoSize = true;
            this.labelAverageBedtime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAverageBedtime.Location = new System.Drawing.Point(313, 260);
            this.labelAverageBedtime.Name = "labelAverageBedtime";
            this.labelAverageBedtime.Size = new System.Drawing.Size(108, 15);
            this.labelAverageBedtime.TabIndex = 11;
            this.labelAverageBedtime.Text = "Average Bedtime:";
            // 
            // labelValueAverageBedtime
            // 
            this.labelValueAverageBedtime.AutoSize = true;
            this.labelValueAverageBedtime.Location = new System.Drawing.Point(313, 275);
            this.labelValueAverageBedtime.Name = "labelValueAverageBedtime";
            this.labelValueAverageBedtime.Size = new System.Drawing.Size(38, 15);
            this.labelValueAverageBedtime.TabIndex = 12;
            this.labelValueAverageBedtime.Text = "label1";
            // 
            // labelAverageWakeTime
            // 
            this.labelAverageWakeTime.AutoSize = true;
            this.labelAverageWakeTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAverageWakeTime.Location = new System.Drawing.Point(313, 317);
            this.labelAverageWakeTime.Name = "labelAverageWakeTime";
            this.labelAverageWakeTime.Size = new System.Drawing.Size(123, 15);
            this.labelAverageWakeTime.TabIndex = 13;
            this.labelAverageWakeTime.Text = "Average Wake Time:";
            // 
            // labelValueAverageWakeTime
            // 
            this.labelValueAverageWakeTime.AutoSize = true;
            this.labelValueAverageWakeTime.Location = new System.Drawing.Point(313, 332);
            this.labelValueAverageWakeTime.Name = "labelValueAverageWakeTime";
            this.labelValueAverageWakeTime.Size = new System.Drawing.Size(38, 15);
            this.labelValueAverageWakeTime.TabIndex = 14;
            this.labelValueAverageWakeTime.Text = "label1";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.labelValueAverageWakeTime);
            this.Controls.Add(this.labelAverageWakeTime);
            this.Controls.Add(this.labelValueAverageBedtime);
            this.Controls.Add(this.labelAverageBedtime);
            this.Controls.Add(this.labelValueAverageTimeAsleep);
            this.Controls.Add(this.labelAverageTimeAsleep);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.labelValueBestRecord);
            this.Controls.Add(this.labelValueWorstRecord);
            this.Controls.Add(this.labelValueLastRecord);
            this.Controls.Add(this.labelBestRecord);
            this.Controls.Add(this.labelWorstRecord);
            this.Controls.Add(this.labelLastRecord);
            this.Controls.Add(this.richTextBoxSleepRecords);
            this.Controls.Add(this.labelStatistics);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStatistics";
            this.Text = "Sleep Logger - Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelStatistics;
        private RichTextBox richTextBoxSleepRecords;
        private Label labelLastRecord;
        private Label labelWorstRecord;
        private Label labelBestRecord;
        private Label labelValueLastRecord;
        private Label labelValueWorstRecord;
        private Label labelValueBestRecord;
        private Label labelRecords;
        private Label labelAverageTimeAsleep;
        private Label labelValueAverageTimeAsleep;
        private Label labelAverageBedtime;
        private Label labelValueAverageBedtime;
        private Label labelAverageWakeTime;
        private Label labelValueAverageWakeTime;
    }
}