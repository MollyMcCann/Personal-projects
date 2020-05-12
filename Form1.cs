using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetWorthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caculatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Local Varibles
                decimal funds;
                decimal properties;
                decimal retirement;
                decimal debt;
                decimal mortgage;
                decimal bills;
                decimal totalAssets;
                decimal totalLiabilities;
                decimal netWorth;
                //get amounts of money from assets
                funds = decimal.Parse(fundsTextBox.Text);
                properties = decimal.Parse(propertiesTextBox.Text);
                retirement = decimal.Parse(retirementTextbox.Text);
                totalAssets = funds + properties + retirement;

                ///get amount of money from Liabilities
                debt = decimal.Parse(debtTextBox.Text);
                mortgage = decimal.Parse(mortgageTextbox.Text);
                bills = decimal.Parse(billsTextBox.Text);
                totalLiabilities = debt + mortgage + bills;

                //caculate the net worth
                netWorth = totalAssets - totalLiabilities;

                //display the net worth
                netWorthLbL.Text = netWorth.ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            fundsTextBox.Text = "";
            propertiesTextBox.Text = "";
            retirementTextbox.Text = "";
            debtTextBox.Text = "";
            billsTextBox.Text = "";
            mortgageTextbox.Text = "";
            netWorthLbL.Text = "";
        }
    }
}
