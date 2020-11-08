using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApplication
{
    public class Auto
    {
        public string country = null;
        public string cost = null;
        public string marka = null;
        public string model = null;
        public string year = null;
        public string color = null;
        public Auto() { }
        public Auto(string[] data)
        {
            country = data[0];
            cost = data[1];
            marka = data[2];
            model = data[3];
            year = data[4];
            color = data[5];
        }
        public bool Compare(Auto obj)
        {
            if((this.country == obj.country) &&
                (this.cost == obj.cost) && 
                (this.marka == obj.marka) && 
                (this.model == obj.model) && 
                (this.year == obj.year) && 
                (this.color == obj.color))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
