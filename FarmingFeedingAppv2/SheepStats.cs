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
            lblAllSummary.Text = sm.allSummary(sm.CostPerGram());
            
            
        }

        private void bunHome_Click(object sender, EventArgs e)
        {
            //closes form and opens a new one
            this.Hide();
            Home myNewForm = new Home(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
