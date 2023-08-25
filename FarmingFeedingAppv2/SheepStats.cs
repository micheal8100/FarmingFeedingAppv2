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
    public partial class SheepStats : Form
    {

        SheepManager sm;
        public SheepStats(SheepManager sm)
        {
            this.sm = sm;
            InitializeComponent();

            //populates the lblBreedSum lable with the sumarry in sm
            lblAllSummary.Text = sm.AllSummary();

            //changes the font color for all writing in this form 
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(77)))));

            // makes it so the user cant maximum the form
            this.MaximizeBox = false; ;

            // changes the broder style for the form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

        private void bunHome_Click(object sender, EventArgs e)
        {
            //closes form and opens a new one
            this.Hide();
            Home myNewForm = new Home(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void bunSheepStatGraph_Click(object sender, EventArgs e)
        {
            //closes form and opens a new one
            this.Hide();
            SheepStatGraph myNewForm = new SheepStatGraph(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
