using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //ARRAY LIST,hashtalbe사용할수있게해주는 전처리기 

namespace Pos
{

    public partial class Form1 : Form
    {
        private Boolean mouseDown = false;
        private Point startPos;
        private Point endPos;
        Button a = new Button();
        int i = 20;
        public Button[] btn_initial_value=new Button[16];
        public Button[] btn_Array = new Button[16]; //테이블 1~ 16 까지 저장해놓을 배열 
        private TableReset[] tableReset = new TableReset[16]; //테이블들의 초기 좌표값을 저장해놓은 클래스 
        private Table[] table = new Table[16]; //각각의 테이블 들의 정보를 저장할 클래스 지정




        public Form1()
        {
            InitializeComponent();
        }




        private void btn_table1_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }
        private void btn_table3_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table5_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table6_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table7_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table8_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table9_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table10_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table11_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table12_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table13_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table14_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table15_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

        private void btn_table16_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
        }

       




        private void Form1_Load(object sender, EventArgs e)
        {
            func1(sender, e);
        }

        private void btn_tableAdd_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < table.Length; i++)
            {
                if (btn_Array[i].Visible == false)
                {
                    btn_Array[i].Visible = true;
                    break;
                }

            }
        }
        private void btn_tabledelete_Click(object sender, EventArgs e)
        {
            a.Visible = false;

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tableText_Click(object sender, EventArgs e)
        {
            a.Text = txt_table.Text;
        }

        private void btn_tableSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new Table();
                table[i].Table_num = i;
                table[i].Table_name = btn_Array[i].Name;
                table[i].Table_x = btn_Array[i].Location.X;
                table[i].Table_y = btn_Array[i].Location.Y;
                table[i].Table_Width = btn_Array[i].Width;
                table[i].Table_Height = btn_Array[i].Height;
            }

            btn_change.Enabled = true;

            btn_tableReset.Enabled = false;
            btn_tableAdd.Enabled = false;
            btn_tabledelete.Enabled = false;
            btn_tableText.Enabled = false;
            btn_tableSave.Enabled = false;
            txt_table.Enabled = false;


            MessageBox.Show("저장이 완료되었습니다!");



        }

        void func1(object sender, EventArgs e)
        {
            btn_initial_value[0]= btn_table1;
            btn_initial_value[1]= btn_table2;
            btn_initial_value[2]= btn_table3;
            btn_initial_value[3]= btn_table4;
            btn_initial_value[4]= btn_table5;
            btn_initial_value[5]= btn_table6;
            btn_initial_value[6]= btn_table7;
            btn_initial_value[7]= btn_table8;
            btn_initial_value[8]= btn_table9;
            btn_initial_value[9]= btn_table10;
            btn_initial_value[10]= btn_table11;
            btn_initial_value[11]= btn_table12;
            btn_initial_value[12]= btn_table13;
            btn_initial_value[13]= btn_table14;
            btn_initial_value[14]= btn_table15;
            btn_initial_value[15]= btn_table16;


            for (int i = 0; i < table.Length; i++)
            {
                tableReset[i] = new TableReset();
                tableReset[i].ntable_text = btn_initial_value[i].Text;
                tableReset[i].nTable_num = i;
                tableReset[i].nTable_name = btn_initial_value[i].Name;
                tableReset[i].nTable_x = btn_initial_value[i].Location.X;
                tableReset[i].nTable_y = btn_initial_value[i].Location.Y;
                tableReset[i].nTable_Width = btn_initial_value[i].Width;
                tableReset[i].nTable_Height = btn_initial_value[i].Height;
            }
          
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
           btn_Array[0] = btn_table1;
           btn_Array[1] = btn_table2;
           btn_Array[2] = btn_table3;
           btn_Array[3] = btn_table4;
           btn_Array[4] = btn_table5;
           btn_Array[5] = btn_table6;
           btn_Array[6] = btn_table7;
           btn_Array[7] = btn_table8;
           btn_Array[8] = btn_table9;
           btn_Array[9] = btn_table10;
           btn_Array[10] = btn_table11;
           btn_Array[11] = btn_table12;
           btn_Array[12] = btn_table13;
           btn_Array[13] = btn_table14;
           btn_Array[14] = btn_table15;
           btn_Array[15] = btn_table16;
           
           

            btn_tableReset.Enabled = true;
            btn_tableAdd.Enabled = true;
            btn_tabledelete.Enabled = true;
            btn_tableText.Enabled = true;
            btn_tableSave.Enabled = true;
            txt_table.Enabled = true;
            btn_change.Enabled = false;

        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_table_Click(object sender, EventArgs e)
        {
            txt_table.Clear();
        }

        private void btn_tableReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Length; i++)
            {
                btn_Array[i].Text = tableReset[i].ntable_text;
                i = tableReset[i].nTable_num;
                btn_Array[i].Name = tableReset[i].nTable_name;
                btn_Array[i].Location = new Point(tableReset[i].nTable_x, tableReset[i].nTable_y);
                btn_Array[i].Location = btn_Array[i].Location;
                btn_Array[i].Width = tableReset[i].nTable_Width;
                btn_Array[i].Height = tableReset[i].nTable_Height;

                btn_Array[i].Visible = true;

            }

        }

        void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == false) return;
            endPos = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
            Point temp = new Point((((Button)sender).Location.X + (endPos.X - startPos.X)),
                            (((Button)sender).Location.Y + (endPos.Y - startPos.Y)));
            startPos = endPos;
            ((Button)sender).Location = temp;
        }

        void MouseDown(object sender, MouseEventArgs e)
        {
            if (btn_tableAdd.Enabled == true)
            {
                mouseDown = true;
                startPos = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
            }
        }

        void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void btn_table1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e); 
        }
        private void btn_table1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table1_MouseMove(object sender, MouseEventArgs e)
        {
            
                MouseMove(sender, e);
        }



        private void btn_table2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table2_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table3_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table3_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table3_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table4_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table4_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table5_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table5_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table5_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table6_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table6_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table6_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table7_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table7_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table7_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table8_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table8_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table8_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table9_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table9_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table9_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table10_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table10_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table10_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table11_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table11_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table11_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table12_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table12_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table12_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table13_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table13_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table13_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table14_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table14_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table14_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table15_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table15_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table15_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void btn_table16_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void btn_table16_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btn_table16_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

      
    }
}
