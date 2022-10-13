using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Pos
{
    public partial class Orderwindow : Form
    {
        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";

        double Cash = 0;      // 받은 금액
        double SumCash = 0;   // 받을 금액
        public int receipt_number_count = 1;
        public int receipt_number_id = 1;
        public int order_number_count = 1;
        
        public int table_number = 1;
        public int Total_money = 0;
        public int profit = 0;
        public int Cash_money = 0;
        public int Card_money = 0;

 
        int[] count = new int[27];
        
        public Table2 order_table = new Table2();
        


        public Orderwindow(int table_num)
        {
            InitializeComponent();
            table_number = table_num;
            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        }

        void order_table_new()
        {
            for (int i = 0; i < order_table._menu.Length; i++)
            {
                order_table._menu[i] = new Table_Menu2();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] array = new Button[27];
            array[0] = btn_Menu2_1; array[1] = btn_Menu2_2; array[2] = btn_Menu2_3; array[3] = btn_Menu2_5; array[4] = btn_Menu2_6; array[5] = btn_Menu2_7; array[6] = btn_Menu2_9;
            array[7] = btn_Menu2_10; array[8] = btn_Menu2_11; array[9] = btn_Menu3_1; array[10] = btn_Menu3_2; array[11] = btn_Menu3_3; array[12] = btn_Menu3_5; array[13] = btn_Menu3_6;
            array[14] = btn_Menu3_7; array[15] = btn_Menu3_9; array[16] = btn_Menu3_10; array[17] = btn_Menu3_11; array[18] = btn_Menu6_1; array[19] = btn_Menu6_2; array[20] = btn_Menu6_3;
            array[21] = btn_Menu6_5; array[22] = btn_Menu6_6; array[23] = btn_Menu6_7; array[24] = btn_Menu6_9; array[25] = btn_Menu6_10; array[26] = btn_Menu6_11;
            int i = 0;

            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string selectQuery = string.Format("SELECT * FROM menu");
                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader table = command.ExecuteReader();

                
                while (table.Read())
                {
                    array[i].Text = table["Name"].ToString();
                    i++;
                }
                table.Close();
            }
            for(int j=0; j<array.Length; j++)
            {
                array[j].Click += new EventHandler(Menu_insert);
            }
            tb_Cash.Text = "";
            order_table_new();
            Sale_Window parent = (Sale_Window)Owner; //부모폼의 데이터를 받아 parent에 저장
            
            receipt_number_count = parent.receipt_number;
            receipt_number_id = parent.receipt_id;
            order_number_count = parent.order_id;
            
            //order_table = parent.sale_table[table_number];
            
            int Total_money = 0;
            for (i = 0; i < parent.sale_table[table_number]._menu.Length; i++)
            {
                order_table._menu[i].number = i + 1;
                order_table._menu[i].menu = parent.sale_table[table_number]._menu[i].menu;
                order_table._menu[i].cost = parent.sale_table[table_number]._menu[i].cost;
                order_table._menu[i].count = parent.sale_table[table_number]._menu[i].count;
                order_table._menu[i].payment = parent.sale_table[table_number]._menu[i].payment;
                count[i] = parent.sale_table[table_number]._menu[i].count;
            }
            i = 0;
            for(int k=0;k < 27; k++)
            {
                if(order_table._menu[i].cost == 0)
                {
                    break;
                }
                ListViewItem item = new ListViewItem();
                item.Text = order_table._menu[i].number.ToString();
                item.SubItems.Add(order_table._menu[i].menu);
                item.SubItems.Add(order_table._menu[i].cost.ToString());
                item.SubItems.Add(order_table._menu[i].count.ToString());
                item.SubItems.Add(order_table._menu[i].payment.ToString());
                lv_Order.Items.Add(item);
                Total_money += order_table._menu[i].payment;
                i++;
                
            }
            tb_Total.Text = Total_money.ToString();
        }

        private void btn_SelectCancle_Click(object sender, EventArgs e)
        {
            if (lv_Order.FocusedItem.Selected == true)
            {
                lv_Order.Items.Remove(lv_Order.FocusedItem);
            }
            else
            {
                MessageBox.Show("선택된 메뉴가 없습니다. 메뉴를 선택하고 다시 눌러주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QuantityChange_Click(object sender, EventArgs e)
        {

        }

        private void btn_AllCancle_Click(object sender, EventArgs e)
        {
            int count = lv_Order.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("취소할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lv_Order.Items.Clear();
                MessageBox.Show("모든 메뉴를 초기화 했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Total.Text = "0";
            }


        }

        private void btn_Discount_Click(object sender, EventArgs e)
        {
            tb_SumCash.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Discount.Text)).ToString();
        }

        private void tb_Total_TextChanged(object sender, EventArgs e)
        {
            tb_SumCash.Text = tb_Total.Text;
        }

        private void btn_Calculator1_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 1;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 1;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();

        }

        private void btn_Calculator2_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 2;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 2;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator3_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 3;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 3;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator4_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 4;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 4;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator5_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 5;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 5;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator6_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 6;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 6;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator7_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 7;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 7;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator8_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 8;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 8;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator9_Click(object sender, EventArgs e)
        {
            if (Cash == 0)
            {
                Cash = 9;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            else
            {
                Cash *= 10;
                Cash += 9;
                tb_Cash.Text = Convert.ToString(Cash);
            }
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }
        
        private void btn_CalculatorClear_Click(object sender, EventArgs e)
        {
            Cash = 0;
            tb_Cash.Text = Convert.ToString(Cash);
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator00_Click(object sender, EventArgs e)
        {
            Cash *= 100;
            tb_Cash.Text = Convert.ToString(Cash);
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_Calculator0_Click(object sender, EventArgs e)
        {
            Cash *= 10;
            tb_Cash.Text = Convert.ToString(Cash);
            int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
            tb_Change.Text = save.ToString();
        }

        private void btn_CalculatorBackspace_Click(object sender, EventArgs e)
        {
            if (Cash < 10)
            {
                Cash = 0;
                tb_Cash.Text = Convert.ToString(Cash);
                int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
                tb_Change.Text = save.ToString();
            }
            else
            {

                Cash /= 10;
                Cash = Math.Truncate(1 * Cash) / 1;
                tb_Cash.Text = Convert.ToString(Cash);
                int save = Convert.ToInt32(tb_Cash.Text) - Convert.ToInt32(tb_SumCash.Text);
                tb_Change.Text = save.ToString();

            }
        }

        private void btn_CalculatorEnter_Click(object sender, EventArgs e)
        {
            int save = Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Discount.Text);
            tb_SumCash.Text = save.ToString();
        }

        void QuantityUp(int i)
        {
            //해당하는 아이템의 수량 +1
            int Quantity_Cnt = Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text);
            Quantity_Cnt++;
            lv_Order.Items[i].SubItems[3].Text = Quantity_Cnt.ToString();

            //금액 = 수량 * 단가
            int price = Convert.ToInt32(lv_Order.Items[i].SubItems[2].Text);
            lv_Order.Items[i].SubItems[4].Text = (Quantity_Cnt * price).ToString();

            //실시간으로 나오는 총 금액
            int add = Convert.ToInt32(tb_Total.Text);
            add += Convert.ToInt32(lv_Order.Items[i].SubItems[2].Text);
            tb_Total.Text = add.ToString();

        }
        private void Menu_insert(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mySql = new MySqlConnection(connStr))
                {
                    mySql.Open();
                    string selectQuery = string.Format("SELECT * FROM `menu`");

                    MySqlCommand cmd = new MySqlCommand(selectQuery, mySql);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        int cnt = lv_Order.Items.Count;
                        int i;


                        for (i = 0; i < cnt; i++)
                        {
                            if (table["Name"].ToString() == lv_Order.Items[i].SubItems[1].Text && ((Button)sender).Text == table["Name"].ToString())
                            {
                                QuantityUp(i);
                                
                                break;
                            }
                        }
                        if (i == cnt && ((Button)sender).Text == table["Name"].ToString())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = (cnt+1).ToString();
                            item.SubItems.Add(table["Name"].ToString());
                            item.SubItems.Add(table["Price"].ToString());
                            item.SubItems.Add(1.ToString());
                            item.SubItems.Add(table["Price"].ToString());
                            lv_Order.Items.Add(item);
                            


                            if (tb_Total.Text.Trim().Length > 0)
                            {
                                int sum = Convert.ToInt32(tb_Total.Text);
                                sum += Convert.ToInt32(item.SubItems[2].Text);
                                tb_Total.Text = sum.ToString();
                            }
                            else
                            {
                                tb_Total.Text = item.SubItems[2].Text;
                            }
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
        
        public string order_menu = "";
        private void btn_Order_Click(object sender, EventArgs e)
        {
            string or_Path = "Order\\" + order_number_count.ToString() + ".txt";
            File.Delete(or_Path);

            if (File.Exists(or_Path))
            {
                File.Create(or_Path);
            }
            Cash = 0;



            using (StreamWriter or_writer = new StreamWriter(or_Path))
            {
                or_writer.WriteLine($"{"주문번호",5}");
                or_writer.WriteLine($"{order_number_count,5}");
                or_writer.WriteLine($"메뉴{"수량",5}");
                for (int i = 0; i < lv_Order.Items.Count; i++)
                {

                    if ((Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text) - count[i]) != 0)
                    {
                        or_writer.WriteLine($"{lv_Order.Items[i].SubItems[1].Text}{Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text) - count[i],5}");
                    }
                    
                }
            }

            order_menu = "";
            for (int i = 0; i < lv_Order.Items.Count; i++)
            {
                
                if ((Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text) - count[i]) > 0)
                {
                    order_menu += lv_Order.Items[i].SubItems[0].Text + "." + lv_Order.Items[i].SubItems[1].Text + "." + (Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text) - count[i]) + ",";
                }
                count[i] = Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text);
            }

            if (order_menu != "")
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string path = "Order\\\\" + order_number_count.ToString() + ".txt";
                    string selectQuery = string.Format("INSERT INTO `order`(`idOrder`, `Table`, `Order`, `order_com`, `Order_position`) VALUES ('{0}', '{1}','{2}','{3}','{4}');",
                        order_number_count, table_number, order_menu, "x", path);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    command.ExecuteNonQuery();
                }
                order_number_count++;
            }
            order_table_value();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tb_SumCash_TextChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(tb_SumCash.Text) == 0 && Convert.ToInt32(tb_Total.Text) != 0)
            {
                for (int i = 0; i < lv_Order.Items.Count; i++)
                {
                    bool check = false;
                    int id_cnt = 0, count = 0, cnt = 0;
                    string category = "";
                    using (MySqlConnection mysql = new MySqlConnection(connStr))
                    {
                        mysql.Open();
                        string selectQuery_dead = string.Format("SELECT * FROM `deadline_menu`");
                        string selectQuery_menu = string.Format("SELECT * FROM `menu`");
                        MySqlCommand selectcmd_dead = new MySqlCommand(selectQuery_dead, mysql);
                        MySqlCommand selectcmd_menu = new MySqlCommand(selectQuery_menu, mysql);
                        MySqlDataReader table_dead = selectcmd_dead.ExecuteReader();
                        while (table_dead.Read())
                        {
                            if (orderWin_date.Text == table_dead["date"].ToString() && lv_Order.Items[i].SubItems[1].Text == table_dead["menu"].ToString())
                            {
                                count = Convert.ToInt32(table_dead["count"].ToString()) + Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text);
                                cnt = Convert.ToInt32(table_dead["id"].ToString());
                                check = true;
                            }
                            id_cnt = Convert.ToInt32(table_dead["id"].ToString()) + 1;
                        }
                        table_dead.Close();

                        if (check)
                        {
                            string updateQuery = string.Format("UPDATE `deadline_menu` SET count = '{1}' WHERE id = {0}", cnt, count);
                            MySqlCommand updatecmd = new MySqlCommand(updateQuery, mysql);
                            updatecmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlDataReader table_menu = selectcmd_menu.ExecuteReader();
                            while (table_menu.Read())
                            {
                                if (lv_Order.Items[i].SubItems[1].Text == table_menu["Name"].ToString())
                                {
                                    category = table_menu["category"].ToString();
                                    break;
                                }
                            }
                            table_menu.Close();

                            string insertQuery = string.Format("INSERT INTO `deadline_menu` (id, date, menu, count, category) VALUES ('{0}','{1}','{2}','{3}','{4}');",
                            id_cnt, orderWin_date.Text, lv_Order.Items[i].SubItems[1].Text, Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text), category);
                            MySqlCommand insertcmd = new MySqlCommand(insertQuery, mysql);
                            insertcmd.ExecuteNonQuery();
                        }
                    }
                }
                Total_money = Convert.ToInt32(tb_Total.Text);

                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string path = "Receipt\\\\" + orderWin_date.Text.ToString() + "\\\\" + receipt_number_count.ToString() + ".txt";
                    string selectQuery = string.Format("SELECT * FROM `menu`");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    while (table.Read())
                    {
                        for(int cnt = 0; cnt < lv_Order.Items.Count; cnt++)
                        {
                            if (table["Name"].ToString() == lv_Order.Items[cnt].SubItems[1].Text.ToString())
                            {
                                profit += (Convert.ToInt32(table["cost"].ToString()) * Convert.ToInt32(lv_Order.Items[cnt].SubItems[3].Text));
                            }
                        }                        
                    }
                }
                for (int i = 0; i < 27; i++)
                {
                    order_table._menu[i].number = 0;
                    order_table._menu[i].menu = "";
                    order_table._menu[i].cost = 0;
                    order_table._menu[i].count = 0;
                    order_table._menu[i].payment = 0;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            Cash = 0;
            if (tb_Cash.Text == "")
            {
                MessageBox.Show("금액을 입력해 주세요!");
            }
            else
            {
                int sumcash = Convert.ToInt32(tb_SumCash.Text);
                int cash = Convert.ToInt32(tb_Cash.Text);
                if (cash > sumcash)
                {
                    tb_Change.Text = (cash - sumcash).ToString();
                    tb_SumCash.Text = "0";
                    Cash_money = sumcash;
                }
                else
                {
                    tb_Change.Text = "0";
                    tb_SumCash.Text = (sumcash - cash).ToString();
                    Cash_money = cash;
                }
                receipt_print();
            }
            tb_Cash.Text = "";
        }

        public void receipt_print()
        {
            
            string re_Path = "Receipt\\" + orderWin_date.Text.ToString() +"-"+ receipt_number_count.ToString() + ".txt";

            File.Delete(re_Path);
            if (File.Exists(re_Path))
            {
                File.Create(re_Path);
            }
            using (StreamWriter writer = new StreamWriter(re_Path))
            {
                writer.WriteLine($"{orderWin_date.Text,15}");
                writer.WriteLine($"{"영수증",15}");
                writer.WriteLine($"{receipt_number_count,15}");
                writer.WriteLine($"메뉴{"수량",5}{"단가",8}{"금액",10}");
                for (int i = 0; i < lv_Order.Items.Count; i++)
                {
                    writer.WriteLine($"{lv_Order.Items[i].SubItems[1].Text}{lv_Order.Items[i].SubItems[3].Text,5}{lv_Order.Items[i].SubItems[2].Text,8}{lv_Order.Items[i].SubItems[4].Text,10}");
                }
                writer.Write($"카드 {Card_money}");
                writer.WriteLine();
                writer.WriteLine($"현금 {Card_money}");
            }
            using (MySqlConnection mysql = new MySqlConnection(connStr))
            {
                mysql.Open();
                string path = "Receipt\\\\" + orderWin_date.Text.ToString() + "-" + receipt_number_count.ToString() + ".txt";
                string selectQuery = string.Format("INSERT INTO `receipt`(idreceipt, Date, number, payment, cash, card, refund, receipt_position) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
                    receipt_number_id, orderWin_date.Text, receipt_number_count, Convert.ToInt32(tb_Total.Text), Cash_money, Card_money, "x", path);

                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                command.ExecuteNonQuery();
            }
            receipt_number_id++;
            receipt_number_count++;
        
        }
        private void btn_Card_Click(object sender, EventArgs e)
        {
            Cash = 0;
            int sumcash = Convert.ToInt32(tb_SumCash.Text);
            if (sumcash != 0)
            {
                if (MessageBox.Show("카드결제 하시겠습니까 ?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    if (tb_Cash.Text == "")
                    {
                        Card_money = sumcash;
                        tb_SumCash.Text = "0";
                    }
                    else
                    {
                        int cash = Convert.ToInt32(tb_Cash.Text);
                        Card_money = cash;
                        tb_SumCash.Text = (sumcash - cash).ToString();
                    }
                    MessageBox.Show("결제되었습니다.");
                }
            }
            else
                MessageBox.Show("주문내역이 없습니다.");
                     
            receipt_print();
            tb_Cash.Text = "0";
        }

        public void order_table_value()
        {
            for(int i =0; i< lv_Order.Items.Count; i++)
            {
                order_table._menu[i].menu = lv_Order.Items[i].SubItems[1].Text;
                order_table._menu[i].cost = Convert.ToInt32(lv_Order.Items[i].SubItems[2].Text);
                order_table._menu[i].count = Convert.ToInt32(lv_Order.Items[i].SubItems[3].Text);
                order_table._menu[i].payment = Convert.ToInt32(lv_Order.Items[i].SubItems[4].Text);
            }
            
        }

        private void tb_Change_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tb_Change.Text) <= 0)
            {
                tb_Change.Text = "0";
            }
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (lv_Order.FocusedItem.Selected == true)
            {
                int quantity = Convert.ToInt32(lv_Order.FocusedItem.SubItems[3].Text);
                quantity--;

                if (quantity > 0)
                {
                    lv_Order.FocusedItem.SubItems[3].Text = quantity.ToString();

                    int lv_total = Convert.ToInt32(lv_Order.FocusedItem.SubItems[4].Text) - Convert.ToInt32(lv_Order.FocusedItem.SubItems[2].Text);
                    lv_Order.FocusedItem.SubItems[4].Text = lv_total.ToString();

                    int tb_total = Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(lv_Order.FocusedItem.SubItems[2].Text);
                    tb_Total.Text = tb_total.ToString();
                }
                else
                {
                    int tb_total = Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(lv_Order.FocusedItem.SubItems[2].Text);
                    tb_Total.Text = tb_total.ToString();

                    lv_Order.Items.Remove(lv_Order.FocusedItem);
                }
            }
            else
            {
                MessageBox.Show("선택된 메뉴가 없습니다. 메뉴를 선택하고 다시 눌러주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (lv_Order.FocusedItem.Selected == true)
            {
                int quantity = Convert.ToInt32(lv_Order.FocusedItem.SubItems[3].Text);
                quantity++;

                if (quantity > 0)
                {
                    lv_Order.FocusedItem.SubItems[3].Text = quantity.ToString();

                    int lv_total = Convert.ToInt32(lv_Order.FocusedItem.SubItems[4].Text) + Convert.ToInt32(lv_Order.FocusedItem.SubItems[2].Text);
                    lv_Order.FocusedItem.SubItems[4].Text = lv_total.ToString();

                    int tb_total = Convert.ToInt32(tb_Total.Text) + Convert.ToInt32(lv_Order.FocusedItem.SubItems[2].Text);
                    tb_Total.Text = tb_total.ToString();


                }
                else
                {
                    int tb_total = Convert.ToInt32(tb_Total.Text) + Convert.ToInt32(lv_Order.FocusedItem.SubItems[2].Text);
                    tb_Total.Text = tb_total.ToString();


                    lv_Order.Items.Remove(lv_Order.FocusedItem);
                }
            }
            else
            {
                MessageBox.Show("선택된 메뉴가 없습니다. 메뉴를 선택하고 다시 눌러주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        int index = 0;
        private void btn_Up_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                lv_Order.Focus(); //리스트 뷰의 선택된 값을 한칸식 올린다
                lv_Order.Items[index - 1].Selected = true;
                lv_Order.Items[index].Selected = false;
                index--;
            }
            else
            {
                index++;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if(index < lv_Order.Items.Count-1)
            {
                lv_Order.Focus();
                lv_Order.Items[index + 1].Selected = true;
                lv_Order.Items[index].Selected = false;
                index++;
            }
            else
            {
                index--;
            }
        }

        private void Orderwindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
