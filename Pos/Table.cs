using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos
{
    internal class Table //저장시에 불러올 클래스 
    {
        private int _table_num;
        private string _table_name;
        private int _table_x;
        private int _table_y;
        private int _table_Width;
        private int _table_Height;
        public Table_Menu[] _menu = new Table_Menu[27];


        public int Table_num { get { return _table_num; } set { _table_num = value; } }
        public string Table_name { get { return _table_name; } set { _table_name = value; } }
        public int Table_x { get { return _table_x; } set { _table_x = value; } }
        public int Table_y { get { return _table_y; } set { _table_y = value; } }
        public int Table_Width { get { return _table_Width; } set { _table_Width = value; } }
        public int Table_Height { get { return _table_Height; } set { _table_Height = value; } }
        





    }

    public class TableReset//초기값이 저장되어있는 클래스 
    {
        private string _ntable_text; // 테이블의 텍스트
        private int _ntable_num; //테이블이 저장되어있는 배열의 인덱스
        private string _ntable_name; //테이블 이름
        private int _ntable_x; //테이블 x좌표값
        private int _ntable_y; //테이블 y좌표값
        private int _ntable_Width; //테이블의 가로크기
        private int _ntable_Height; //테이블의 세로크기


        public string ntable_text {  get { return _ntable_text; } set { _ntable_text = value; } }
        public int nTable_num { get { return _ntable_num; } set { _ntable_num = value; } } //get set
        public string nTable_name { get { return _ntable_name; } set { _ntable_name = value; } }
        public int nTable_x { get { return _ntable_x; } set { _ntable_x = value; } }
        public int nTable_y { get { return _ntable_y; } set { _ntable_y = value; } }
        public int nTable_Width { get { return _ntable_Width; } set { _ntable_Width = value; } }
        public int nTable_Height { get { return _ntable_Height; } set { _ntable_Height = value; } }






    }

    class Table_Menu : Table 
    {
        private int _number;
        private string _menu;
        private int _cost;
        private int _count;
        private int _payment;
        private int _bigo;
    }
}
