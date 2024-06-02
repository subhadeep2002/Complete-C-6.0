using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class Class11
    {
        partial void m1();
        partial void m1()
        {
            Console.WriteLine("Partial method m1");
        }
        public void m2() 
        {
            Console.WriteLine("Non Partial method m2");
            m1();
        }
    }
}
