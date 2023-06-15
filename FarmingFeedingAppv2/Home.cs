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
    public partial class Home : Form
    {
        SheepManager sm;
        public Home(SheepManager sm)
        {
            this.sm = sm;
            InitializeComponent();
        }

        private void bunAddSheep_Click(object sender, EventArgs e)
        {
            // hides form and then opens a new form
            this.Hide();
            AddSheep myNewForm = new AddSheep(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void bunSheepStats_Click(object sender, EventArgs e)
        {
            // hides form and then opens a new form
            this.Hide();
            SheepStats myNewForm = new SheepStats(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
