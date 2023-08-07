
namespace FarmingFeedingAppv2
{
    partial class Home
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
            this.lblHome = new System.Windows.Forms.Label();
            this.bunAddSheep = new System.Windows.Forms.Button();
            this.bunSheepStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(776, 139);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Sheep Feeding App";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunAddSheep
            // 
            this.bunAddSheep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunAddSheep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunAddSheep.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunAddSheep.Location = new System.Drawing.Point(208, 157);
            this.bunAddSheep.Name = "bunAddSheep";
            this.bunAddSheep.Size = new System.Drawing.Size(381, 104);
            this.bunAddSheep.TabIndex = 1;
            this.bunAddSheep.Text = "Add Sheep";
            this.bunAddSheep.UseVisualStyleBackColor = false;
            this.bunAddSheep.Click += new System.EventHandler(this.bunAddSheep_Click);
            // 
            // bunSheepStats
            // 
            this.bunSheepStats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunSheepStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunSheepStats.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunSheepStats.Location = new System.Drawing.Point(209, 301);
            this.bunSheepStats.Name = "bunSheepStats";
            this.bunSheepStats.Size = new System.Drawing.Size(380, 104);
            this.bunSheepStats.TabIndex = 2;
            this.bunSheepStats.Text = "Sheep Stats";
            this.bunSheepStats.UseVisualStyleBackColor = false;
            this.bunSheepStats.Click += new System.EventHandler(this.bunSheepStats_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunSheepStats);
            this.Controls.Add(this.bunAddSheep);
            this.Controls.Add(this.lblHome);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button bunAddSheep;
        private System.Windows.Forms.Button bunSheepStats;
    }
}

