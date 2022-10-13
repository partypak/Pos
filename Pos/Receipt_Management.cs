using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;

namespace Pos
{
    public partial class Receipt_Management : Form
    {

        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";

        public Receipt_Management()
        {
            InitializeComponent();
            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        }

        private void btn_receipt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void receipt_Date_ValueChanged(object sender, EventArgs e)
        {
            tb_business_day.Text = receipt_Date.Text;
        }

        private void btn_Sreach_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tb_receipt_number.Text))
            {
                MessageBox.Show("영수증 번호를 입력해 주세요");
            }
            else
            {
            
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM receipt"); //receipt테이블을 읽음

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    int i = 0;
                    while (table.Read())
                    {
                        string num = tb_receipt_number.Text;
                        if (tb_business_day.Text == table["Date"].ToString() && table["number"].ToString() == num)
                        {//선택된 날짜와 영수번호가 같다면 해당하는 경로의 파일을 불러온다
                            tb_receipt.Text = File.ReadAllText(table["receipt_position"].ToString());
                            break;
                        }
                        i++;
                    }
                    table.Close();
                }
            }     
        }

        private void Receipt_Management_Load(object sender, EventArgs e)
        {
            receipt_Date.Value = System.DateTime.Today;
        }

        private void lv_receipt_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(lv_receipt_list.FocusedItem.SubItems[0].Text);
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM receipt");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        if (tb_business_day.Text == table["Date"].ToString() && Convert.ToInt32(table["number"].ToString()) == num)
                        {
                            tb_receipt.Text = File.ReadAllText(table["receipt_position"].ToString());
                        }
                    }


                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        private void btn_reprint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + tb_receipt.Text + "");
        }

        private void btn_refund_Click(object sender, EventArgs e)
        {
            //선택된 인덱스에 해당하는 영수증을 환불 처리한다.
            int index = lv_receipt_list.FocusedItem.Index;
            lv_receipt_list.Items[index].SubItems[4].Text = "●";
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string updateQuery = string.Format("UPDATE receipt SET refund = '{1}' WhERE idreceipt = {0}",index, "●");
                //만약 영수증 id가 같다면 해당하는 refund의 값을 ●로 변경한다.
                MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                command.ExecuteNonQuery();
                
            }
        }

        private void tb_business_day_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();      
                    string selectQuery = string.Format("SELECT * FROM receipt");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    lv_receipt_list.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        if (table["Date"].ToString() == tb_business_day.Text)
                        {
                            item.Text = table["number"].ToString();
                            item.SubItems.Add(table["payment"].ToString());
                            item.SubItems.Add(table["cash"].ToString());
                            item.SubItems.Add(table["card"].ToString());
                            item.SubItems.Add(table["refund"].ToString());
                            lv_receipt_list.Items.Add(item);
                        }
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
