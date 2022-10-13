using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pos
{
    public partial class Sbp_Form : Form
    {

        string host = "localhost";
        int port = 3306;
        string database = "pos_db";
        string uid = "root";
        string pwd = "1234";
        string connStr = "";
        public Sbp_Form()
        {
            InitializeComponent();

            connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        }





        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sbp_Form_Load(object sender, EventArgs e)
        {
            Load_listView1();
        }

        private void Load_listView1()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT*FROM deadline_menu");
                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    int i = 0;
                    while (table.Read())
                    {
                        int count = listView1.Items.Count;
                     
                        int j;

                        for (j = 0; j < count; j++)
                        {
                            if (listView1.Items[j].SubItems[2].Text.ToString() == table["menu"].ToString())
                            {
                                listView1.Items[j].SubItems[3].Text = (Convert.ToInt32(listView1.Items[j].SubItems[3].Text) + Convert.ToInt32(table["count"].ToString())).ToString();
                                break;
                            }
                        }
                        if ((Convert.ToString(table["category"].ToString())) == "메인 메뉴")
                        {
                            if (j == count)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = table["id"].ToString();
                                item.SubItems.Add(table["date"].ToString());
                                item.SubItems.Add(table["menu"].ToString());
                                item.SubItems.Add(table["count"].ToString());
                                item.SubItems.Add(table["category"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                        if ((Convert.ToString(table["category"].ToString())) == "튀김")
                        {
                            if (j == count)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = table["id"].ToString();
                                item.SubItems.Add(table["date"].ToString());
                                item.SubItems.Add(table["menu"].ToString());
                                item.SubItems.Add(table["count"].ToString());
                                item.SubItems.Add(table["category"].ToString());
                                listView2.Items.Add(item);
                            }
                        }
                        if ((Convert.ToString(table["category"].ToString())) == "음료")
                        {
                            if (j == count)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = table["id"].ToString();
                                item.SubItems.Add(table["date"].ToString());
                                item.SubItems.Add(table["menu"].ToString());
                                item.SubItems.Add(table["count"].ToString());
                                item.SubItems.Add(table["category"].ToString());
                                listView3.Items.Add(item);
                            }
                        }
                        i++;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
                tb_date.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            else tb_date.Text = monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");
            string str = tb_date.Text;
            try
            {

                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT*FROM deadline_menu");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    listView1.Items.Clear();
                    listView2.Items.Clear();
                    listView3.Items.Clear();
                    while (table.Read())
                    {
                        int count = listView1.Items.Count;
                        int j;



                        if (Convert.ToString(table["date"].ToString()) == (str.Substring(5, 5)))
                        {
                            for (j = 0; j < count; j++)
                            {
                                if (listView1.Items[j].SubItems[2].Text.ToString() == table["menu"].ToString())
                                {
                                    listView1.Items[j].SubItems[3].Text = (Convert.ToInt32(listView1.Items[j].SubItems[3].Text) + Convert.ToInt32(table["count"].ToString())).ToString();

                                    break;
                                }
                            }


                            if ((Convert.ToString(table["category"].ToString())) == "메인 메뉴")
                            {
                                if (j == count)
                                {
                                    ListViewItem item = new ListViewItem();
                                    item.Text = table["id"].ToString();
                                    item.SubItems.Add(table["date"].ToString());
                                    item.SubItems.Add(table["menu"].ToString());
                                    item.SubItems.Add(table["count"].ToString());
                                    item.SubItems.Add(table["category"].ToString());
                                    listView1.Items.Add(item);
                                }
                            }
                            if ((Convert.ToString(table["category"].ToString())) == "튀김")
                            {
                                if (j == count)
                                {
                                    ListViewItem item = new ListViewItem();
                                    item.Text = table["id"].ToString();
                                    item.SubItems.Add(table["date"].ToString());
                                    item.SubItems.Add(table["menu"].ToString());
                                    item.SubItems.Add(table["count"].ToString());
                                    item.SubItems.Add(table["category"].ToString());
                                    listView2.Items.Add(item);
                                }
                            }
                            if ((Convert.ToString(table["category"].ToString())) == "음료")
                            {
                                if (j == count)
                                {
                                    ListViewItem item = new ListViewItem();
                                    item.Text = table["id"].ToString();
                                    item.SubItems.Add(table["date"].ToString());
                                    item.SubItems.Add(table["menu"].ToString());
                                    item.SubItems.Add(table["count"].ToString());
                                    item.SubItems.Add(table["category"].ToString());
                                    listView3.Items.Add(item);
                                }
                            }
                        }

                    }
                    mysql.Close();
                }

                try
                {

                    using (MySqlConnection mysql = new MySqlConnection(connStr))
                    {
                        mysql.Open();
                        string selectQuery = string.Format("SELECT*FROM deadline");
                        MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                        MySqlDataReader table = command.ExecuteReader();
                        int n = 0, y = 0, u = 0;
                        int sum = 0, g = 0;
                        int n1 = 0, y1 = 0, u1 = 0;
                        int sum1 = 0, g1 = 0;

                        while (table.Read())
                        {
                            int k, r, t;
                            if (Convert.ToString(table["date"].ToString()) == (str.Substring(5, 5)) && g < listView1.Items.Count)

                            {


                                
                                    k= int.Parse((Convert.ToString(table["breakfast"].ToString())));
                                    n += k;

                                
                                   r = int.Parse((Convert.ToString(table["lunch"].ToString())));
                                    y += r;

                               
                                    t = int.Parse((Convert.ToString(table["evening"].ToString())));
                                    u += t;



                                

                            }
                            int k1, r1, t1;
                            if (Convert.ToString(table["date"].ToString()).Substring(0,2) == (str.Substring(5, 2)) )

                            {



                                k1 = int.Parse((Convert.ToString(table["breakfast"].ToString())));
                                n1 += k1;


                                r1 = int.Parse((Convert.ToString(table["lunch"].ToString())));
                                y1 += r1;


                                t1 = int.Parse((Convert.ToString(table["evening"].ToString())));
                                u1 += t1;





                            }
                            sum1 = n1 + y1 + u1;
                            sum = n + y + u;
                            tb_Morning.Text = n.ToString();
                            tb_Lunch.Text = y.ToString();
                            tb_Dinner.Text = u.ToString();
                            tb_Daysum.Text = sum.ToString();
                            tb_month.Text = sum1.ToString();


                        }


                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }


            } catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            Load_listView1();
            tb_Daysum.Text = "0";
            tb_Dinner.Text = "0";
            tb_Lunch.Text = "0";
            tb_Morning.Text = "0";

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Sbp_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
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


