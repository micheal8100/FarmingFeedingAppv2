
using System.Collections.Generic;

namespace FarmingFeedingAppv2
{
    partial class AddSheep
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
            this.lblAddSheep = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbSheepBreeds = new System.Windows.Forms.ComboBox();
            this.lblSheepBreeds = new System.Windows.Forms.Label();
            this.lblSheepAge = new System.Windows.Forms.Label();
            this.nudSheepAge = new System.Windows.Forms.NumericUpDown();
            this.lblFoodConsumed = new List<System.Windows.Forms.Label>();
            this.nudFoodConsumed = new List<System.Windows.Forms.NumericUpDown>();
            this.bunCancel = new System.Windows.Forms.Button();
            this.bunConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheepAge)).BeginInit();

            foreach (var item in nudFoodConsumed)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).BeginInit();
            }
            
            this.SuspendLayout();

            int tabIndex = 0;
            // 
            // lblAddSheep
            // 
            this.lblAddSheep.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSheep.Location = new System.Drawing.Point(12, 9);
            this.lblAddSheep.Name = "lblAddSheep";
            this.lblAddSheep.Size = new System.Drawing.Size(262, 175);
            this.lblAddSheep.TabIndex = tabIndex;
            tabIndex++;
            this.lblAddSheep.Text = "Add Sheep";
            this.lblAddSheep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSheepBreeds
            // 
            this.lblAddSheep.AutoSize = true;
            this.lblSheepBreeds.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheepBreeds.Location = new System.Drawing.Point(17, 159);
            this.lblSheepBreeds.Name = "lblSheepBreeds";
            this.lblSheepBreeds.Size = new System.Drawing.Size(134, 42);
            this.lblSheepBreeds.TabIndex = tabIndex;
            tabIndex++;
            this.lblSheepBreeds.Text = "Select a sheep breed";
            this.lblSheepBreeds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSheepBreeds
            // 

            this.cmbSheepBreeds.FormattingEnabled = true;
            this.cmbSheepBreeds.Location = new System.Drawing.Point(17, 204);
            this.cmbSheepBreeds.Name = "cmbSheepBreeds";
            this.cmbSheepBreeds.Size = new System.Drawing.Size(134, 21);
            this.cmbSheepBreeds.TabIndex = tabIndex;
            tabIndex++;
            // 
            // lblSheepAge
            // 
            this.lblSheepAge.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheepAge.Location = new System.Drawing.Point(17, 244);
            this.lblSheepAge.Name = "lblSheepAge";
            this.lblSheepAge.Size = new System.Drawing.Size(134, 42);
            this.lblSheepAge.TabIndex = tabIndex;
            tabIndex++;
            this.lblSheepAge.Text = "Select sheep age";
            this.lblSheepAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSheepAge
            // 
            this.nudSheepAge.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSheepAge.Location = new System.Drawing.Point(17, 289);
            this.nudSheepAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSheepAge.Name = "nudSheepAge";
            this.nudSheepAge.Size = new System.Drawing.Size(134, 25);
            this.nudSheepAge.TabIndex = tabIndex;
            tabIndex++;
            // 
            // lblFoodConsumed
            // 
            int lblfoodConsumedY = 59;
            int foddConsumedX = 206;
            //loop though to make all the food lbls at once
            for (int i = 1; i < 8; i++)
            {
                
                lblfoodConsumedY += 70;
                if (lblfoodConsumedY > 339)
                {
                    foddConsumedX = 550;
                    lblfoodConsumedY = 129;
                }
                lblFoodConsumed.Add(new System.Windows.Forms.Label());
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].Location = new System.Drawing.Point(foddConsumedX, lblfoodConsumedY);
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].Name = "lblFoodConsumed";
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].Size = new System.Drawing.Size(200, 38);
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].TabIndex = tabIndex;
                tabIndex++;
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].Text = "Food Consumed Day " + i;
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].AutoSize = true;
                this.lblFoodConsumed[lblFoodConsumed.Count - 1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                
            }
            // 
            // nudFoodConsumed
            // 
            foddConsumedX = 206;
            int nudfoodConsumedY = 95;
            //loop though to make all the food nuds at once
            for (int i = 1; i < 8; i++)
            {
                nudfoodConsumedY += 70;
                if (nudfoodConsumedY > 384)
                {
                    foddConsumedX = 550;
                    nudfoodConsumedY = 165;
                }
                nudFoodConsumed.Add(new System.Windows.Forms.NumericUpDown());
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Location = new System.Drawing.Point(foddConsumedX , nudfoodConsumedY);
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Name = "lblFoodConsumed";
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Size = new System.Drawing.Size(200, 38);
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Maximum = 5000;
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].TabIndex = tabIndex;
                tabIndex++;
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Text = "Food Consumed Day " + i;
                this.nudFoodConsumed[nudFoodConsumed.Count - 1].Increment = new decimal(new int[] {
                50,
                0,
                0,
                0});
                }
            // 
            // bunCancel
            // 
            this.bunCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunCancel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunCancel.Location = new System.Drawing.Point(648, 380);
            this.bunCancel.Name = "bunCancel";
            this.bunCancel.Size = new System.Drawing.Size(140, 58);
            this.bunCancel.TabIndex = tabIndex;
            tabIndex++;
            this.bunCancel.Text = "Cancel";
            this.bunCancel.UseVisualStyleBackColor = false;
            this.bunCancel.Click += new System.EventHandler(this.bunCancel_Click);
            // 
            // bunConfirm
            // 
            this.bunConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunConfirm.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunConfirm.Location = new System.Drawing.Point(500, 380);
            this.bunConfirm.Name = "bunConfirm";
            this.bunConfirm.Size = new System.Drawing.Size(140, 58);
            this.bunConfirm.TabIndex = tabIndex;
            tabIndex++;
            this.bunConfirm.Text = "Confirm";
            this.bunConfirm.UseVisualStyleBackColor = false;
            this.bunConfirm.Click += new System.EventHandler(this.bunConfirm_Click);
            // 
            // AddSheep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunConfirm);
            this.Controls.Add(this.bunCancel);
          
            this.Controls.Add(this.nudSheepAge);
            this.Controls.Add(this.lblSheepAge);
            this.Controls.Add(this.lblSheepBreeds);
            this.Controls.Add(this.cmbSheepBreeds);
            this.Controls.Add(this.lblAddSheep);
            this.Name = "AddSheep";
            this.Text = "AddSheep";
            ((System.ComponentModel.ISupportInitialize)(this.nudSheepAge)).EndInit();
            foreach (var item in nudFoodConsumed)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).EndInit();
            }
            
            this.ResumeLayout(false);
            // adding each food consumed label to add sheep form
            foreach (var item in lblFoodConsumed)
            {
                this.Controls.Add(item);
            }
            // adding each food consumed numrical up and down to add sheep form
            foreach (var item in nudFoodConsumed)
            {
                this.Controls.Add(item);
            }
        }

        #endregion

        private System.Windows.Forms.Label lblAddSheep;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbSheepBreeds;
        private System.Windows.Forms.Label lblSheepBreeds;
        private System.Windows.Forms.Label lblSheepAge;
        private System.Windows.Forms.NumericUpDown nudSheepAge;
        private List<System.Windows.Forms.Label> lblFoodConsumed;
        private List<System.Windows.Forms.NumericUpDown> nudFoodConsumed;
        private System.Windows.Forms.Button bunCancel;
        private System.Windows.Forms.Button bunConfirm;
    }
}