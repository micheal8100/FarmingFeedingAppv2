
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblHome = new System.Windows.Forms.Label();
            this.bunAddSheep = new System.Windows.Forms.Button();
            this.bunSheepStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblHome, "lblHome");
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(77)))));
            this.lblHome.Name = "lblHome";
            // 
            // bunAddSheep
            // 
            this.bunAddSheep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(186)))));
            resources.ApplyResources(this.bunAddSheep, "bunAddSheep");
            this.bunAddSheep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(77)))));
            this.bunAddSheep.Name = "bunAddSheep";
            this.bunAddSheep.UseVisualStyleBackColor = false;
            this.bunAddSheep.Click += new System.EventHandler(this.bunAddSheep_Click);
            // 
            // bunSheepStats
            // 
            this.bunSheepStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(186)))));
            resources.ApplyResources(this.bunSheepStats, "bunSheepStats");
            this.bunSheepStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(77)))));
            this.bunSheepStats.Name = "bunSheepStats";
            this.bunSheepStats.UseVisualStyleBackColor = false;
            this.bunSheepStats.Click += new System.EventHandler(this.bunSheepStats_Click);
            // 
            // Home
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::FarmingFeedingAppv2.Properties.Resources.backroundImageFarmingApp;
            this.Controls.Add(this.bunSheepStats);
            this.Controls.Add(this.bunAddSheep);
            this.Controls.Add(this.lblHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button bunAddSheep;
        private System.Windows.Forms.Button bunSheepStats;
    }
}

