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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btn_MenuSet_Click(object sender, EventArgs e)
        {
            this.Hide();
            btn_Menu5_ MenuSEt = new btn_Menu5_();
            MenuSEt.ShowDialog();
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("F");
        }

     

        private void btn_Past_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form2 = new Home();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            table_Setting table_Set = new table_Setting();
            table_Set.ShowDialog();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        
    }
}
