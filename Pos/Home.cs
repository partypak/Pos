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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale_Window setting = new Sale_Window();
            setting.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sbp_Form sbp = new Sbp_Form();
           sbp.ShowDialog();
            
        }

        

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting setting = new Setting();
            setting.ShowDialog();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("F");
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
