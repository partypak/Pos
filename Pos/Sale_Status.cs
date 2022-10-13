using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Sale_Status : Form
    {
        int Total_money;
        int profit;

        public Sale_Status(int Total_mon, int _profit)
        {
            InitializeComponent();
            Total_money = Total_mon;
            profit = _profit;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sale_Status_Load(object sender, EventArgs e)
        {
            tb_profit.Enabled = false;
            tb_Sale_cost.Enabled = false;
            tb_profit.Text = profit.ToString();
            tb_Sale_cost.Text = Total_money.ToString();
        }
    }
}
