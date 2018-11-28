using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Division
    {
        public double Number { get; set; }

        public double Divide(double num)
        {
            return num / Number;
        }

        public Division()
        {
            Number = 0;
        }
    }
}
