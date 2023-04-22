using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_Korondenko
{
    public class Jewerly
    {
        private string _name;
        private int _carates;
        private int _price;
        private string _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Carates
        {
            get { return _carates; }
            set { _carates = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
       /* public Jewerly (string Name, int Carates, int Price, string Type)
        {
            _name = Name;
            _carates = Carates;
            _price = Price;
            _type = Type;

        }
       */
    }
}
