using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arithmetic
    {
        int num1, num2, result;
        public int Pnum1 
        { 
            set { num1 = value; }
        }
        public int Pnum2
        {
            set { num2 = value; }
        }
        public int Presult
        {
            get { return result; }
        }
        public void Add()
        {
            result = num1 + num2;
        }
        public void Sub()
        {
            result = num1 - num2;
        }
        public void Mul()
        {
            result = num1 * num2;
        }
        public void Div()
        {
            result = num1 / num2;
        }
    }
}
