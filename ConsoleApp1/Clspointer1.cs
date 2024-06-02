using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal unsafe class Clspointer1
    {
        static void square(int*x)
        {
            Console.WriteLine("square is:" + *x * *x);
        }
        static void cube(int*x) 
        {
            Console.WriteLine("cube is:" + *x * *x * *x);
        }
        static void Main(string[] args)
        {
            int a = 9;
            square(&a);
            cube(&a);
            Console.Read();
        }
    }
}
