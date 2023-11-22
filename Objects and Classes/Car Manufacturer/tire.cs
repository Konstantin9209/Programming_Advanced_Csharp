using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Manufacturer
{
    public class tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        public tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
