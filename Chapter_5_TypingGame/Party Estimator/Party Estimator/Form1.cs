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
        public formPartyPlanner()
        {
            DinnerParty dinnerParty;
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 }; 
            dinnerParty.SetHealthyOption(false); 
            dinnerParty.CalculateCostOfDecorations(true); 
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = DinnerParty.CalculateCosts();
            costLabel.Text = Cost.ToString("c");
        }

        internal static decimal CalculateCosts()
        {
            throw new NotImplementedException();
        }
        private void DisplayDinnerPartyCost()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void peopleCounter_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)peopleCounter.Value; 
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateCosts();
        }
    }
}
