using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos
{
    public class Table2
    {

        public Table_Menu2[] _menu = new Table_Menu2[27];
        
        public void table_menu_array()
        {
            for(int i = 0; i < _menu.Length; i++)
            {
                _menu[i] = new Table_Menu2();
            }
        }








    }

    public class Table_Menu2 : Table2
    {
        private int _number;
        private string _menu;
        private int _cost;
        private int _count;
        private int _payment;

        public int number { get { return _number; } set { _number = value; } }
        public string menu { get { return _menu; } set { _menu = value; } }
        public int cost { get { return _cost; } set { _cost = value; } }
        public int count { get { return _count; } set { _count = value; } }
        public int payment { get { return _payment; } set { _payment = value; } }

    }
}
