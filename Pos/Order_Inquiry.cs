using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using System.IO;

namespace Pos
{
    public partial class Order_Inquiry : Form
    {

        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";
        public Order_Inquiry()
        {
            InitializeComponent();
            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        }

        private void btn_Order_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Inquiry_Load(object sender, EventArgs e)
        {
            //로드시 시작 인덱스
            //DB에서 주문을 받아와 리스트 뷰에 넣는다
            Order_DB();
        }
        void Order_DB()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM `order`");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    lv_Order_Inquiry.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["idOrder"].ToString();
                        item.SubItems.Add(table["Table"].ToString());
                        item.SubItems.Add(table["Order"].ToString());
                        item.SubItems.Add(table["order_com"].ToString());
                        lv_Order_Inquiry.Items.Add(item);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            if (lv_Order_Inquiry.FocusedItem.Index == 0)
            {
                MessageBox.Show("주문서를 선택해주세요!");
                return;
            }
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                int pos = lv_Order_Inquiry.FocusedItem.Index;
                int index = Convert.ToInt32(lv_Order_Inquiry.Items[pos].SubItems[0].Text);
                string updateQuery = string.Format("UPDATE `order` SET order_com = '{1}' WHERE idOrder = {0};", index, "●");
                MySqlCommand cmd = new MySqlCommand(updateQuery, mysql);
                string selectQuery = string.Format("SELECT * FROM `order`");
                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                cmd.ExecuteNonQuery();
                MySqlDataReader table = command.ExecuteReader();

                while (table.Read())
                {
                    int lv_id = Convert.ToInt32(lv_Order_Inquiry.Items[lv_Order_Inquiry.FocusedItem.Index].SubItems[0].Text);
                    if(lv_id == Convert.ToInt32(table["idOrder"]))
                    {
                        string order = File.ReadAllText(table["Order_position"].ToString());
                        MessageBox.Show(order);
                    }
                } 
                table.Close();
            }
            Order_DB();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    int pos = lv_Order_Inquiry.FocusedItem.Index;
                    int index = Convert.ToInt32(lv_Order_Inquiry.Items[pos].Text);
                    string delectQuery = string.Format("DELETE FROM `order` WHERE idOrder={0};",index);

                    MySqlCommand command = new MySqlCommand(delectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    lv_Order_Inquiry.Items.Clear();
                    Order_DB();

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();                
                string delectQuery = string.Format("DELETE FROM `order` ;");
                MySqlCommand command = new MySqlCommand(delectQuery, mysql);
                command.ExecuteNonQuery();                
                      
            }
            DialogResult = DialogResult.OK;
        }
    }
}
