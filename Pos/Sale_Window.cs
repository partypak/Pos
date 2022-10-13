using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Pos
{
    
    public partial class Sale_Window : Form
    {
        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";

        public Table2[] sale_table = new Table2[16];
        public int table_number = 1;
        public int order_number = 1;
        public int order_id = 1;
        public int receipt_number = 1;
        public int receipt_id = 1;
        public int profit = 0;
        public int Total_money = 0;
        public int breakfast = 0;
        public int lunch = 0;
        public int evening = 0;
        public int Cash_money = 0;
        public int Card_money = 0;


        public Button btn_clone = new Button();
        
        public Sale_Window()
        {
            InitializeComponent();
            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);

        }

        void sale_table_new() //클래스를 배열로 선언 할시에 배열의 요소 각각 새로 객체를 할당해 줘야한다.
        {
            for(int j=0; j<sale_table.Length; j++)
            {
                sale_table[j] = new Table2();
                for (int i = 0; i < sale_table[j]._menu.Length; i++)
                {
                    sale_table[j]._menu[i] = new Table_Menu2();
                }
            }
            
        }

        private void btn_receipt_mangement_Click(object sender, EventArgs e)
        {
            Receipt_Management receipt_Manage = new Receipt_Management();
            receipt_Manage.Show();
        }

        private void btn_sale_status_Click(object sender, EventArgs e)
        {
            Sale_Status status = new Sale_Status(Total_money, profit);
            status.Show();
            
        }

        private void btn_order_receipt_Click(object sender, EventArgs e)
        {
            Order_Inquiry inquiry = new Order_Inquiry();
            DialogResult result = inquiry.ShowDialog();
            if(result == DialogResult.OK)
            {
                order_id = 1;
            }
            
        }

        private void btn_mone_Click(object sender, EventArgs e)
        {
            btn_move.Enabled = false;
        }

        void table_func(object sender, int table_num)
        {
            if (!btn_move.Enabled)
            {
                if(tb_hidden.Text == "")
                {
                    tb_hidden.Text = ((Button)sender).Text;
                    ((Button)sender).Text = "테이블";
                    btn_clone = (Button)sender;
                }
                else
                {
                    Button temp = new Button();
                    temp.Name = btn_clone.Name;
                    btn_clone.Name = ((Button)sender).Name;
                    ((Button)sender).Name = temp.Name;
                    
                    ((Button)sender).Text = tb_hidden.Text;

                    tb_hidden.Text = "";
                    btn_move.Enabled = true;
                }
            }
            else
            {
                Orderwindow orderwindow = new Orderwindow(table_num); //자식폼 (Orderwindow) 선언
                orderwindow.Owner = this; //자식폼의 Owner 변수에 부모폼(현재폼)의 데이터를 넘김
                DialogResult result = orderwindow.ShowDialog(); //자식폼의 DialogResult를 받아옴
                if(result == DialogResult.OK)
                {
                    for(int i = 0; i < sale_table[table_number]._menu.Length; i++)
                    {
                        sale_table[table_num]._menu[i].number = i+1;
                        sale_table[table_num]._menu[i].menu = orderwindow.order_table._menu[i].menu;
                        sale_table[table_num]._menu[i].cost = orderwindow.order_table._menu[i].cost;
                        sale_table[table_num]._menu[i].count = orderwindow.order_table._menu[i].count;
                        sale_table[table_num]._menu[i].payment = orderwindow.order_table._menu[i].payment;
                    }
                    sale_table[table_num] = orderwindow.order_table;
                    order_id = orderwindow.order_number_count;
                    receipt_number = orderwindow.receipt_number_count;
                    receipt_id = orderwindow.receipt_number_id;
                    Total_money += orderwindow.Total_money;
                    profit += orderwindow.profit;
                    Cash_money += orderwindow.Cash_money;
                    Card_money += orderwindow.Card_money;

                }
                orderwindow.Dispose();
                int now = Convert.ToInt32(DateTime.Now.ToString("HH"));
                if (now <= 12 && now >= 6)
                {
                    breakfast = Total_money - (lunch + evening);
                }
                if (now > 12 && now < 18)
                {
                    lunch = Total_money - (breakfast + evening);
                }
                if (now >= 18 && now <= 24)
                {
                    evening = Total_money - (breakfast + lunch);
                }
                table_text(sender, table_num);

            }
        }
        void table_text(object sender, int table_num)
        {
            ((Button)sender).Text = "";
            for (int i=0; i<27; i++)
            {
                if (sale_table[table_num]._menu[i].cost != 0)
                {
                    ((Button)sender).Text += sale_table[table_num]._menu[i].menu + sale_table[table_num]._menu[i].count.ToString()+"\n";
                }
                else
                {
                    break;
                }
            }
        }

        private void table_click_event(object sender, EventArgs e)
        {
            
            int table_num = 0;
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string selectQuery = string.Format("SELECT * FROM `table`");
                MySqlCommand selectcmd = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader table = selectcmd.ExecuteReader();
                while (table.Read())
                {
                    if(((Button)sender).Name == table["table_name"].ToString())
                    {
                        table_num = Convert.ToInt32(table["table_num"].ToString());
                        break;
                    }
                }
                table.Close();
            }
            
            table_func(sender, table_num);
        }

        private void Sale_Window_Load(object sender, EventArgs e) //각 테이블들을 읽어서 id값을 받아온다
        {
            sale_table_new();
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string selectQuery_table = string.Format("SELECT * FROM `table`");
                string selectQuery_order = string.Format("SELECT * FROM `order`");
                string selectQuery_receipt = string.Format("SELECT * FROM `receipt`");
                
                MySqlCommand selectcmd_table = new MySqlCommand(selectQuery_table, mysql);
                MySqlCommand selectcmd_order = new MySqlCommand(selectQuery_order, mysql);
                MySqlCommand selectcmd_receipt = new MySqlCommand(selectQuery_receipt, mysql);
                MySqlDataReader table_table = selectcmd_table.ExecuteReader();
                while (table_table.Read())
                {
                    Button btn_clone = new Button(); //Button 객체 생성
                    if (table_table["hidden"].ToString()== "Y") // 삭제된 테이블의 MySql hiddend의 "Y" 항목만 생성
                    {
                    btn_clone.Click += new EventHandler(table_click_event); //생성된 Button의 Click 이벤트에 table_click_event 함수 할당
                    this.Controls.Add(btn_clone); //현제 폼에 Button 생성
                    btn_clone.Name = table_table["table_name"].ToString(); //Button의 이름
                    btn_clone.Width = Convert.ToInt32(table_table["table_width"].ToString()); //Button의 가로
                    btn_clone.Height = Convert.ToInt32(table_table["table_height"].ToString()); //Button의 높이
                    btn_clone.Location = new Point(Convert.ToInt32(table_table["table_x"].ToString()), Convert.ToInt32(table_table["table_y"].ToString()));
                    //Button의 좌표
                    btn_clone.Text = "테이블"; //Button의 텍스트
                    }
                }
                table_table.Close();
                MySqlDataReader table_order = selectcmd_order.ExecuteReader();
                while (table_order.Read())
                {
                    order_id = Convert.ToInt32(table_order["idOrder"].ToString())+1;
                }
                table_order.Close();
                MySqlDataReader table_receipt = selectcmd_receipt.ExecuteReader();
                while (table_receipt.Read())
                {
                    receipt_id = Convert.ToInt32(table_receipt["idreceipt"])+1;
                    if (table_receipt["Date"].ToString() == TodayDate.Text)
                    {
                        receipt_number = Convert.ToInt32(table_receipt["number"].ToString()) + 1;
                    }
                }
                table_receipt.Close();
            }
        }

        private void Sale_Window_FormClosing(object sender, FormClosingEventArgs e) //폼이 닫힐때 deadline테이블에 값저장 만약 오늘 날짜의 데이터가 있다면 수정하고 없다면 추가한다.
        {
            int sales = 0; int profit2 = 0; int cash = 0; int card = 0; int breakfast2 = 0; int lunch2 = 0; int evening2 = 0;
            bool check = true;
            using (MySqlConnection mySql = new MySqlConnection(connStr))
            {
                mySql.Open();

                string selectQuery = string.Format("SELECT * FROM deadline");
                MySqlCommand selectcmd = new MySqlCommand(selectQuery, mySql);
                MySqlDataReader table = selectcmd.ExecuteReader();

                while (table.Read())
                {
                    if (table["date"].ToString() == TodayDate.Text)
                    {
                        check = false;
                        sales = Convert.ToInt32(table["sales"].ToString()) + Total_money;
                        profit2 = Convert.ToInt32(table["profit"].ToString()) + profit;
                        cash = Convert.ToInt32(table["cash"].ToString()) + Cash_money;
                        card = Convert.ToInt32(table["card"].ToString()) + Card_money;
                        breakfast2 = Convert.ToInt32(table["breakfast"].ToString()) + breakfast;
                        lunch2 = Convert.ToInt32(table["lunch"].ToString()) + lunch;
                        evening2 = Convert.ToInt32(table["evening"].ToString()) + evening;
                        break;
                    }
                }
                table.Close();
                if (!check)
                {
                    string updateQuery = string.Format("UPDATE deadline SET sales = {0}, profit = {1}, cash = {2}, card = {3}, breakfast = {4}, lunch = {5}, evening = {6} WHERE date = '{7}'",
                    sales, profit2, cash, card, breakfast2, lunch2, evening2, TodayDate.Text.ToString());
                    MySqlCommand updatecmd = new MySqlCommand(updateQuery, mySql);
                    updatecmd.ExecuteNonQuery();

                }
                else
                {
                    string insertQuery = string.Format("INSERT INTO deadline (date, sales, profit, cash, card, breakfast, lunch, evening) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                   TodayDate.Text, Total_money, profit, Cash_money, Card_money, breakfast, lunch, evening);
                    MySqlCommand insertcmd = new MySqlCommand(insertQuery, mySql);
                    insertcmd.ExecuteNonQuery();
                }
                
            }
            Application.Exit();

        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form2 = new Home();
            form2.ShowDialog();
        }
    }
}
