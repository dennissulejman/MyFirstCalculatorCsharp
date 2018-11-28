using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Multiplication
    {
        public double Number { get; set; }

        public double Multiply(double num)
        {
            return num * Number;
        }
        
        public Multiplication()
        {
            Number = 0;
        }
    }
}
