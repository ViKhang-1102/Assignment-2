using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Bill : Form
    {
        public Bill(string customerName, double lastMonth, double thisMonth,
                    double consumption, double waterMoney)
        {
            InitializeComponent();

            this.txtCustomerName.Text = customerName;
            this.txtLastMonth.Text = lastMonth.ToString();
            this.txtThisMonth.Text = thisMonth.ToString();
            this.txtConsumption.Text = consumption.ToString();
            this.txtWaterMoney.Text = waterMoney.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("      You have successfully paid.",
               "Notification", MessageBoxButtons.OK);
        }       
    }
}
