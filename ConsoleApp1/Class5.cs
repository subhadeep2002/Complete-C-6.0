using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int i = 10;
            string s = "durga";//string is a collection type
            char c = 's';
            float f = 34.56f;
            double d = 34.56;
            bool b = true;
            long l = 5643535;

            Console.WriteLine(i + "...."+sizeof(int));
            Console.WriteLine(s+".....");
            Console.WriteLine(c + "...." + sizeof(char));
            Console.WriteLine(f + "...." + sizeof(float));
            Console.WriteLine(d + "...." + sizeof(double));
            Console.WriteLine(b + "...." + sizeof(bool));
            Console.WriteLine(l + "...." + sizeof(long));
            Console.ReadLine();

        }
    }
}
