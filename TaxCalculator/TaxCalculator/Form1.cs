using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            this.btnComputer.Click += btnComputer_Click;
        }

        void btnComputer_Click(object sender, EventArgs e)
        {
            String strToTalAmount = this.txtTotalAmount.Text;
            int TotalAmount = int.Parse(strToTalAmount);

            string strTaxPercentage = this.label5.Text;
            strTaxPercentage = strTaxPercentage.Replace("%", "");
            double taxPerCentage = double.Parse(strTaxPercentage);

            double totalDue = TotalAmount * (100 + taxPerCentage) / 100;
            this.totalDue.Text = totalDue.ToString();
        }
        
    }
}
