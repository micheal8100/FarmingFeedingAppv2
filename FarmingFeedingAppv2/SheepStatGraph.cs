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
    public partial class SheepStatGraph : Form
    {
        SheepManager sm;
        public SheepStatGraph(SheepManager sm)
        {
            this.sm =sm;
            InitializeComponent();
        }

        private void bunHome_Click(object sender, EventArgs e)
        {
            //closes form and opens a new one
            this.Hide();
            Home myNewForm = new Home(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void bunSheepStats_Click(object sender, EventArgs e)
        {
            //closes form and opens a new one
            this.Hide();
            SheepStats myNewForm = new SheepStats(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
