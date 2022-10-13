using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pos
{
    public class Pos1
    {
        public Pos_Number[] _number = new Pos_Number[9];

        public void Pos_number_array()
        {
            for (int i = 0; i < _number.Length; i++)
            {
                _number[i] = new Pos_Number();
            }
        }

        public class Pos_Number : Pos1
        {
            private int _number;
            private string _name;
            private int _price;
            private int _sales;
            private int _total;
            private string _date;
            public int number { get { return _number; } set { _number = value; } }
            public string name { get { return _name; } set { _name = value; } }
            public int price { get { return _price; } set { _price = value; } }
            public int sales { get { return _sales; } set { _sales = value; } }
            public int total { get { return _total; } set { _total = value; } }
            private string date { get { return _date; } set { _date = value; } }
        }
        public class Pos2
        {
            public Pos_Name[] _name = new Pos_Name[9];

            public void Pos_name_array()
            {
                for (int i = 0; i < _name.Length; i++)
                {
                    _name[i] = new Pos_Name();
                }
            }

            public class Pos_Name : Pos2
            {
                private int _number;
                private string _name;
                private int _price;
                private int _sales;
                private int _total;
                private string _date;
                public int number { get { return _number; } set { _number = value; } }
                public string name { get { return _name; } set { _name = value; } }
                public int price { get { return _price; } set { _price = value; } }
                public int sales { get { return _sales; } set { _sales = value; } }
                public int total { get { return _total; } set { _total = value; } }
                private string date { get { return _date; } set { _date = value; } }
            }

            public class Pos3
            {
                public Pos_Price[] _price = new Pos_Price[9];

                public void Pos_price_array()
                {
                    for (int i = 0; i < _price.Length; i++)
                    {
                        _price[i] = new Pos_Price();
                    }
                }

                public class Pos_Price : Pos3
                {
                    private int _number;
                    private string _name;
                    private int _price;
                    private int _sales;
                    private int _total;
                    private string _date;
                    public int number { get { return _number; } set { _number = value; } }
                    public string name { get { return _name; } set { _name = value; } }
                    public int price { get { return _price; } set { _price = value; } }
                    public int sales { get { return _sales; } set { _sales = value; } }
                    public int total { get { return _total; } set { _total = value; } }
                    private string date { get { return _date; } set { _date = value; } }
                }
                public class Pos4
                {
                    public Pos_Sales[] _sales = new Pos_Sales[9];

                    public void Pos_sales_array()
                    {
                        for (int i = 0; i < _sales.Length; i++)
                        {
                            _sales[i] = new Pos_Sales();
                        }
                    }

                    public class Pos_Sales : Pos4
                    {
                        private int _number;
                        private string _name;
                        private int _price;
                        private int _sales;
                        private int _total;
                        private string _date;
                        public int number { get { return _number; } set { _number = value; } }
                        public string name { get { return _name; } set { _name = value; } }
                        public int price { get { return _price; } set { _price = value; } }
                        public int sales { get { return _sales; } set { _sales = value; } }
                        public int total { get { return _total; } set { _total = value; } }
                        private string date { get { return _date; } set { _date = value; } }
                    }
                    public class Pos5
                    {
                        public Pos_Total[] _total = new Pos_Total[9];

                        public void Pos_total_array()
                        {
                            for (int i = 0; i < _total.Length; i++)
                            {
                                _total[i] = new Pos_Total();
                            }
                        }

                        public class Pos_Total : Pos5
                        {
                            private int _number;
                            private string _name;
                            private int _price;
                            private int _sales;
                            private int _total;
                            private string _date;
                            public int number { get { return _number; } set { _number = value; } }
                            public string name { get { return _name; } set { _name = value; } }
                            public int price { get { return _price; } set { _price = value; } }
                            public int sales { get { return _sales; } set { _sales = value; } }
                            public int total { get { return _total; } set { _total = value; } }
                            private string date { get { return _date; } set { _date = value; } }
                        }
                        public class Pos6
                        {
                            public Pos_Date[] _date = new Pos_Date[9];

                            public void Pos_date_array()
                            {
                                for (int i = 0; i < _date.Length; i++)
                                {
                                    _date[i] = new Pos_Date();
                                }
                            }

                            public class Pos_Date : Pos6
                            {
                                private int _number;
                                private string _name;
                                private int _price;
                                private int _sales;
                                private int _total;
                                private string _date;
                                public int number { get { return _number; } set { _number = value; } }
                                public string name { get { return _name; } set { _name = value; } }
                                public int price { get { return _price; } set { _price = value; } }
                                public int sales { get { return _sales; } set { _sales = value; } }
                                public int total { get { return _total; } set { _total = value; } }
                                private string date { get { return _date; } set { _date = value; } }
                            }
                        }
                    }
                }
            }
        }
    }
}


