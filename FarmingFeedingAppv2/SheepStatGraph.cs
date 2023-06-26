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

        }

        private void bunSheepStats_Click(object sender, EventArgs e)
        {

        }
    }
}
