using MySql.Data.MySqlClient;
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
    public partial class login : Form
    {
        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";

        public login()
        {
            InitializeComponent();
            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        }

        private void login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            id_pw_get();

        }

        private void id_pw_get()
        {
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();

                string selectQuery = string.Format("SELECT * FROM login");
                MySqlCommand selectcmd = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader table = selectcmd.ExecuteReader();

                while (table.Read())
                {
                    tb_id_hidden.Text = table["id"].ToString();
                    tb_pw_hidden.Text = table["pw"].ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("F");

            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == tb_id_hidden.Text && tb_pw.Text == tb_pw_hidden.Text)
            {
                if (btn_login_change.Enabled)
                {
                    this.Hide();
                    Home Home = new Home();
                    Home.ShowDialog();
                }
                else
                {
                    btn_login.Text = "회원변경";
                }
            }
            else
            {
                if(check == 1)
                {
                    using (MySqlConnection mysql = new MySqlConnection(connStr))
                    {
                        mysql.Open();

                        string updateQurey = string.Format("UPDATE login SET id = '{0}',pw = '{1}'", tb_id.Text, tb_pw.Text);
                        MySqlCommand updatecmd = new MySqlCommand(updateQurey, mysql);
                        updatecmd.ExecuteNonQuery();

                        id_pw_get();
                    }
                    btn_login.Text = "로그인";
                    btn_login_change.Enabled = true;
                    check = 0;
                }
                else
                {
                    MessageBox.Show("아이디와 비밀번호가 틀렸습니다!\n다시입력 해주세요");
                }
                
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            tb_pw.Clear();
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                tb_pw.PasswordChar = default(char);
            }
            else
            {
                tb_pw.PasswordChar = '*';
            }
        }
        int check = 0;
        private void btn_login_change_Click(object sender, EventArgs e)
        {
            btn_login.Text = "회원확인";
            btn_login_change.Enabled = false;      
            check = 1;
        }
    }
}
