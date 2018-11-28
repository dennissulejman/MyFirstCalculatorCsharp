using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtraction
    {
        public double Number { get; set; }

        public double Subtract(double num)
        {
            return num - Number;
        }

        public Subtraction()
        {
            Number = 0;
        }
    }
}
