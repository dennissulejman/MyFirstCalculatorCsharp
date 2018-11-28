using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Addition
    {
        public double Number { get; set; }

        public double Add(double num)
        {
            return num + Number;
        }

        public Addition()
        {
            Number = 0;
        }

    }
}