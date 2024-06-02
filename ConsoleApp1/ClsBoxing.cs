using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsBoxing
    {
        static void Main(string[] args)
        {
            int i = 10; //normal initialization
            object O = i;//implicit Boxing
            object X = (object)i; //explicit Boxing
            int j = (int)O; //Explicit Unboxing

            Console.WriteLine("Value of i is:"+i);
            Console.WriteLine("Value of O after Implicit Boxing is:" + O);
            Console.WriteLine("Value of X after Explicit Boxing is:" + X);
            Console.WriteLine("Value of J after Implicit UnBoxing is:" + j);
            Console.Read();
        }
    }
}
