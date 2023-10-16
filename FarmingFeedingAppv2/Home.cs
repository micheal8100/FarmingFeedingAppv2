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
        readonly SheepManager sm;
        //constructor - cronstructs an object of this class
        public Home(SheepManager sm)
        {
            this.sm = sm;
            InitializeComponent();
            this.MaximizeBox = false; ;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void BunAddSheep_Click(object sender, EventArgs e)
        {
            // hides form and then opens a new form
            this.Hide();
            AddSheep myNewForm = new AddSheep(sm);
            
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void BunSheepStats_Click(object sender, EventArgs e)
        {
            // hides form and then opens a new form
            this.Hide();
            SheepStats myNewForm = new SheepStats(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
