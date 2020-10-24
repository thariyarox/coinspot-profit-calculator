using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinSpotProfitCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double commission = 0.01;
            double investmentAmount = Convert.ToDouble(txtInvestmentAmount.Text);

            

            double buyingRate = Convert.ToDouble(txtBuyingRate.Text);

            double coinsBought = investmentAmount * (1 - commission) / buyingRate;

            double sellingRate = Convert.ToDouble(txtSellingRate.Text);

            double totalSale = coinsBought * sellingRate * (1 - commission);

            lblTotalSale.Text = totalSale.ToString();

            lblTotalProfit.Text = (totalSale - investmentAmount).ToString();

            double growthPercentage = ((sellingRate - buyingRate) / buyingRate) * 100;

            lblGrowthPercentage.Text = growthPercentage.ToString();
        }
    }
}
