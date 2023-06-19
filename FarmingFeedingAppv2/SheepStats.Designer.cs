
using System.Collections.Generic;

namespace FarmingFeedingAppv2
{
    partial class SheepStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            List<System.Windows.Forms.DataVisualization.Charting.Series> series = new List<System.Windows.Forms.DataVisualization.Charting.Series>();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblSheepStats = new System.Windows.Forms.Label();
            this.lblAllSummary = new System.Windows.Forms.Label();
            this.bunHome = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSheepStats
            // 
            this.lblSheepStats.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheepStats.Location = new System.Drawing.Point(12, 9);
            this.lblSheepStats.Name = "lblSheepStats";
            this.lblSheepStats.Size = new System.Drawing.Size(379, 78);
            this.lblSheepStats.TabIndex = 0;
            this.lblSheepStats.Text = "Sheep Stats";
            this.lblSheepStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllSummary
            // 
            this.lblAllSummary.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllSummary.Location = new System.Drawing.Point(12, 90);
            this.lblAllSummary.Name = "lblAllSummary";
            this.lblAllSummary.Size = new System.Drawing.Size(470, 351);
            this.lblAllSummary.TabIndex = 2;
            // 
            // bunHome
            // 
            this.bunHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunHome.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunHome.Location = new System.Drawing.Point(538, 367);
            this.bunHome.Name = "bunHome";
            this.bunHome.Size = new System.Drawing.Size(189, 71);
            this.bunHome.TabIndex = 5;
            this.bunHome.Text = "Home";
            this.bunHome.UseVisualStyleBackColor = false;
            this.bunHome.Click += new System.EventHandler(this.bunHome_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(488, 61);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Name = "Title";
            title1.Text = "Sheep breeds";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "food consumed";
            title2.Text = "food consumed";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "Breeds";
            title3.Text = "Breeds";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            for (int i = 0; i < sm.GetSheepBreeds().Count; i++)
            {
                series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
                series[series.Count -1].ChartArea = "ChartArea1";
                series[series.Count -1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series[series.Count -1].Legend = "Legend1";
                series[series.Count -1].Name = sm.GetSheepBreeds()[i];
                this.chart1.Series.Add(series[series.Count - 1]);
            }
            // 
            // SheepStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bunHome);
            this.Controls.Add(this.lblAllSummary);
            this.Controls.Add(this.lblSheepStats);
            this.Name = "SheepStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheepStats";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSheepStats;
        private System.Windows.Forms.Label lblAllSummary;
        private System.Windows.Forms.Button bunHome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}