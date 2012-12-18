using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Party_Estimator
{
    public partial class formPartyPlanner : Form
    {
        DinnerParty dinnerParty;
        
        public formPartyPlanner()
        {
            
            InitializeComponent();
            dinnerParty = new DinnerParty(5); 
            dinnerParty.SetHealthyOption(false);
            dinnerParty.SetDecorationType(false);
            //dinnerParty.CalculateCostOfDecorations(true); 
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCosts();
            costText.Text = Cost.ToString("c");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void peopleCounter_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNumberOfPeople((int)peopleCounter.Value); 
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           dinnerParty.SetDecorationType(checkBoxDecoration.Checked);
           DisplayDinnerPartyCost();
        }

        private void checkBoxOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBoxOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void costLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
