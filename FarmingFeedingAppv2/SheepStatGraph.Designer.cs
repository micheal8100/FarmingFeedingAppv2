using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmingFeedingAppv2
{
    partial class SheepStatGraph
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "SheepStatGraph";
            this.bunHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunSheepStats = new System.Windows.Forms.Button();
            // 
            // bunHome
            // 
            this.bunHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunHome.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunHome.Location = new System.Drawing.Point(620, 375);
            this.bunHome.Name = "bunHome";
            this.bunHome.Size = new System.Drawing.Size(168, 63);
            this.bunHome.TabIndex = 0;
            this.bunHome.Text = "Home";
            this.bunHome.UseVisualStyleBackColor = false;
            this.bunHome.Click += new System.EventHandler(this.bunHome_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sheep Stat Graphs";
            // 
            // bunSheepStats
            // 
            this.bunSheepStats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunSheepStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunSheepStats.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunSheepStats.Location = new System.Drawing.Point(620, 306);
            this.bunSheepStats.Name = "bunSheepStats";
            this.bunSheepStats.Size = new System.Drawing.Size(168, 63);
            this.bunSheepStats.TabIndex = 2;
            this.bunSheepStats.Text = "Sheep Stats";
            this.bunSheepStats.UseVisualStyleBackColor = false;
            this.bunSheepStats.Click += new System.EventHandler(this.bunSheepStats_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 75);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(602, 356);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Name = "Title";
            title1.Text = "Sheep breeds food consumed";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "food consumed";
            title2.Text = "food consumed";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "Day";
            title3.Text = "Day";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            List<int> seriesColor = new List<int> { };
            // creating the series for all different sheep breeds 
            for (int i = 0; i < sm.GetSheepBreeds().Count; i++)
            {
                series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
                series[series.Count - 1].ChartArea = "ChartArea1";
                series[series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series[series.Count - 1].Legend = "Legend1";
                series[series.Count - 1].Name = sm.GetSheepBreeds()[i];    
                // adding the sheep breeds points
                foreach (int breedsConsumtion in sm.CalculatTotalCostPerBreedPerDay()[i])
                {                       
                            series[series.Count - 1].Points.Add(breedsConsumtion);
                }
                this.chart1.Series.Add(series[series.Count - 1]);
            }
            // 
            // SheepStatGraph
            // 
            this.BackgroundImage = global::FarmingFeedingAppv2.Properties.Resources.backroundImageFarmingApp;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bunSheepStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunHome);
            this.Name = "SheepStatGraph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
    
        }

      

        #endregion
        private Button bunHome;
        private Label label1;
        private Button bunSheepStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}