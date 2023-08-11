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
    public partial class AddSheep : Form
    {
        
        SheepManager sm;

        public AddSheep(SheepManager sm)
        {
            this.sm = sm;
            InitializeComponent();
            this.MaximizeBox = false; ;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            // list for food counsumded
            List<int> foodConsumed = new List<int>();
            //populates the cmbsheepbreeds combo box
            for (int i = 0; i < sm.GetSheepBreeds().Count; i++)
            {
                cmbSheepBreeds.Items.Add(sm.GetSheepBreeds()[i]);
            }
        }

        private void bunConfirm_Click(object sender, EventArgs e)
        {
            // creats a list for food consumed and populates it
            List<int> FoodConsumed = new List<int>();
            foreach (var item in nudFoodConsumed)
            {
                FoodConsumed.Add((int)item.Value);
            }

            //checks if any of the values in foodConsumed are <0
            for (int i = 0; i < FoodConsumed.Count; i++)
            {
                if (FoodConsumed[i] <= 0)
                {
                    // button to ask if they meant leave food Nud Blank or did it by accident
                    DialogResult dialogResult = MessageBox.Show("Some days are missing values did you mean this?" , "ERROR", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // if yes cancels while loop becuse they meant to

                        i = FoodConsumed.Count + 10;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // if no puts them back onto the form without doing anything
                        return;
                    }
                }
            }

            // makes sure user selects a sheep breed
            if (cmbSheepBreeds.SelectedIndex < 0)
            {
                //displays an error mesage to user
                MessageBox.Show("Please select a sheep breed");
            }
            else
            {
                //adds sheep to sheeps list in Sheep manager class
                Sheep sheep = new Sheep((int)nudSheepAge.Value, sm.GetSheepBreeds()[cmbSheepBreeds.SelectedIndex], FoodConsumed);
                sm.addSheep(sheep);

                //Display summary via a message box
                string message = sheep.summary(sm.CostPerGram(), sm.NumberOfSheep(), sm.determineHealth(sheep.overWeeksFood()));
                string title = sheep.idGenorater(sm.NumberOfSheep()) + " Summary";
                MessageBox.Show(message, title);

                // hides form and then opens a new form
                this.Hide();
                Home myNewForm = new Home(sm);
                myNewForm.Closed += (s, args) => this.Close();
                myNewForm.Show();

            }
        }
        // the button to cancel adding a sheep
        private void bunCancel_Click(object sender, EventArgs e)
        {
            // hides form and then opens a new form
            this.Hide();
            Home myNewForm = new Home(sm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
