
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
            this.lblSheepStats = new System.Windows.Forms.Label();
            this.lblAllSummary = new System.Windows.Forms.Label();
            this.bunHome = new System.Windows.Forms.Button();
            this.bunSheepStatGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSheepStats
            // 
            this.lblSheepStats.BackColor = System.Drawing.Color.Transparent;
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
            this.lblAllSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblAllSummary.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllSummary.Location = new System.Drawing.Point(12, 90);
            this.lblAllSummary.Name = "lblAllSummary";
            this.lblAllSummary.Size = new System.Drawing.Size(470, 351);
            this.lblAllSummary.TabIndex = 2;
            // 
            // bunHome
            // 
            this.bunHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(186)))));
            this.bunHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(77)))));
            this.bunHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunHome.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunHome.Location = new System.Drawing.Point(599, 355);
            this.bunHome.Name = "bunHome";
            this.bunHome.Size = new System.Drawing.Size(189, 71);
            this.bunHome.TabIndex = 5;
            this.bunHome.Text = "Home";
            this.bunHome.UseVisualStyleBackColor = false;
            this.bunHome.Click += new System.EventHandler(this.BunHome_Click);
            // 
            // bunSheepStatGraph
            // 
            this.bunSheepStatGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(186)))));
            this.bunSheepStatGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(77)))));
            this.bunSheepStatGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunSheepStatGraph.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunSheepStatGraph.Location = new System.Drawing.Point(599, 278);
            this.bunSheepStatGraph.Name = "bunSheepStatGraph";
            this.bunSheepStatGraph.Size = new System.Drawing.Size(189, 71);
            this.bunSheepStatGraph.TabIndex = 6;
            this.bunSheepStatGraph.Text = "Graphs";
            this.bunSheepStatGraph.UseVisualStyleBackColor = false;
            this.bunSheepStatGraph.Click += new System.EventHandler(this.BunSheepStatGraph_Click);
            // 
            // SheepStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmingFeedingAppv2.Properties.Resources.backroundImageFarmingApp;

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunSheepStatGraph);
            this.Controls.Add(this.bunHome);
            this.Controls.Add(this.lblAllSummary);
            this.Controls.Add(this.lblSheepStats);
            this.Name = "SheepStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheepStats";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label lblSheepStats;
        private System.Windows.Forms.Label lblAllSummary;
        private System.Windows.Forms.Button bunHome;
        private System.Windows.Forms.Button bunSheepStatGraph;
    }
}