using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;
using MySql.Data.MySqlClient;
using Application = System.Windows.Forms.Application;

namespace Pos
{
    public partial class btn_Menu5_ : Form
    {


        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";


        Button a=new Button();
        Button price = new Button();
        TextBox t = new TextBox();
        public btn_Menu5_()
        {
            InitializeComponent();
            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        }
       




      

        private void btn_Munu_Name_Click(object sender, EventArgs e)
        {
            // DB에 데이터 삽입
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
             mysql.Open(); // MySql 파일 OPEN
             int index = Convert.ToInt32(text_Munu_idmenu.Text); // Text를 정수로 변환후 index에 할당
             string updateQuery = string.Format("UPDATE `menu` SET Name = '{1}',Price='{2}',Cost='{3}' WHERE idmenu = {0};"
             , index, text_Munu_Name.Text, text_Munu_Price.Text, text_Munu_cost.Text);// MySql 메뉴 데이터 수정
             MySqlCommand cmd = new MySqlCommand(updateQuery, mysql); // 커리창에 Table 수정코드 입력
             cmd.ExecuteNonQuery();// MySql 커리창에 있는 명령어 실행
            }

            a.Text = text_Munu_Name.Text;
            a.Text += "\r\n\n"+text_Munu_Price.Text+"원";

            text_Munu_Name.Clear();
            text_Munu_Price.Clear();
            text_Munu_cost.Clear();
            text_Munu_idmenu.Clear();

            
        }
      

        private void btn_cal_8_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "8";
        }

        private void btn_cal_9_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "9";
        }

        private void btn_cal_5_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "5";
        }

        private void btn_cal_6_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "6";
        }

        private void btn_cal_1_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "1";
        }

        private void btn_cal_2_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "2";
        }

        private void btn_cal_3_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "3";
        }

        private void btn_cal_0_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "0";
        }

        private void btn_cal_00_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "00";
        }

        private void btn_cal_C_Click(object sender, EventArgs e)
        {
            txt_cal.Clear();
        }

        private void btn_cal_back_Click(object sender, EventArgs e)
        {
            txt_cal.Text = txt_cal.Text.Substring(0, txt_cal.Text.Length - 1);   
        }


        private void btn_cal_7_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "7";
        }

        private void btn_cal_4_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "4";
        }

        private void btn_cal_ent_Click(object sender, EventArgs e)
        {
            t.Text = txt_cal.Text;
            txt_cal.Clear();
        }


        

  
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            a = (Button)sender;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

   
 
        private void text_Munu_cost_Click(object sender, EventArgs e)
        {
            t = (TextBox)sender;
        }

        private void text_Munu_idmenu_Click(object sender, EventArgs e)
        {
            t = (TextBox)sender;
        }


        private void text_Munu_Name_Click(object sender, EventArgs e)
        {
            t = (TextBox)sender;
        }

        private void text_Munu_Price_Click(object sender, EventArgs e)
        {
            t = (TextBox)sender;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            t = (TextBox)sender;
        }


        void db_show(int n)
        {
            text_Munu_idmenu.Text = n.ToString();

            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string selectQuery = string.Format("SELECT * FROM menu");
                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader table = command.ExecuteReader();
                while (table.Read())
                {
                    if (table["idmenu"].ToString() == text_Munu_idmenu.Text)
                    {
                        text_Munu_Name.Text = table["Name"].ToString(); ;
                        text_Munu_Price.Text = table["Price"].ToString();
                        text_Munu_cost.Text = table["cost"].ToString();
                    }
                }
                table.Close();

            }
        }


        private void btn_Menu2_1_Click(object sender, EventArgs e)
        {
            a = (Button)sender;

            db_show(1);
        }
        private void btn_Menu2_2_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(2);

        }

        private void btn_Menu2_3_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(3);
        }

        private void btn_Menu2_5_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(4);
        }

        private void btn_Menu2_6_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(5);
        }

        private void btn_Menu2_7_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(6);
        }

        private void btn_Menu2_9_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(7);
        }

        private void btn_Menu2_10_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(8);
        }

        private void btn_Menu2_11_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(9);
        }
        private void btn_Menu3_1_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(10);
        }
        private void btn_Menu3_2_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(11);
        }

        private void btn_Menu3_3_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(12);
        }



        private void btn_Menu3_5_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(13);
        }

        private void btn_Menu3_6_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(14);
        }

        private void btn_Menu3_7_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(15);
        }

        private void btn_Menu3_9_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(16);
        }

        private void btn_Menu3_10_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(17);
        }

        private void btn_Menu3_11_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(18);
        }
       
        private void btn_Menu6_1_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(19);
        }

        private void btn_Menu6_2_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(20);
        }

        private void btn_Menu6_3_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(21);
        }
        private void btn_Menu6_5_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(22);
        }

        private void btn_Menu6_6_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(23);
        }

        private void btn_Menu6_7_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(24);
        }

        private void btn_Menu6_9_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(25);
        }

        private void btn_Menu6_10_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(26);
        }

        private void btn_Menu6_11_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            db_show(27);
        }

        private void btn_Menu5__Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            Button[] array = new Button[27];
            array[0] = btn_Menu2_1; array[1] = btn_Menu2_2;  array[2] = btn_Menu2_3; array[3] = btn_Menu2_5; array[4] = btn_Menu2_6; array[5] = btn_Menu2_7; array[6] = btn_Menu2_9;
            array[7] = btn_Menu2_10; array[8] = btn_Menu2_11; array[9] = btn_Menu3_1; array[10] = btn_Menu3_2;  array[11] = btn_Menu3_3;  array[12] = btn_Menu3_5;  array[13] = btn_Menu3_6;
            array[14] = btn_Menu3_7;  array[15] = btn_Menu3_9;  array[16] = btn_Menu3_10; array[17] = btn_Menu3_11;  array[18] = btn_Menu6_1; array[19] = btn_Menu6_2;  array[20] = btn_Menu6_3;
            array[21] = btn_Menu6_5;  array[22] = btn_Menu6_6; array[23] = btn_Menu6_7; array[24] = btn_Menu6_9; array[25] = btn_Menu6_10; array[26] = btn_Menu6_11;


            //text_Munu_idmenu.Text = 
              
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string selectQuery = string.Format("SELECT * FROM menu");
                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader table = command.ExecuteReader();

                int i = 0;
                while (table.Read())
                {
                    array[i].Text = table["Name"].ToString();
                    array[i].Text += "\r\n\n" + table["Price"].ToString() + "원";
                    //a.Text = text_Munu_Name.Text;
                    //a.Text += "\r\n\n" + text_Munu_Price.Text + "원";

                    //text_Munu_Price.Text = table["Price"].ToString();
                    //    text_Munu_cost.Text = table["Cost"].ToString();
                    
                    i++;
                }
                table.Close();

            }

            //using (MySqlConnection mysql = new MySqlConnection(connStr))
            //{
            //    mysql.Open();
            //    string selectQuery = string.Format("SELECT * FROM pos.menu");
            //    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
            //    MySqlDataReader table = command.ExecuteReader();                                                                             
            //    while (table.Read())
            //    {
            //        if (table["idmenu"].ToString()== text_Munu_idmenu.Text)
            //        {
            //            text_Munu_Name.Text = table["Name"].ToString(); ;
            //            text_Munu_Price.Text = table["Price"].ToString();
            //            text_Munu_cost.Text = table["Cost"].ToString();
            //        }
            //    }
            //    table.Close();

            //}


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("F");
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting setting = new Setting();
            setting.ShowDialog();
            
        }

        private void btn_Menu5__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
