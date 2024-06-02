    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam8_2
    {
        delegate void multiCastDelegate();
        public class MCD
        {
            static public void Display()
            {
                Console.WriteLine("Hello");
            }
            static public void Print() 
            {
                Console.WriteLine("ABC");
            }
        }
        static void Main(string[] args)
        {
            multiCastDelegate mcd1 = new multiCastDelegate(MCD.Display);
            multiCastDelegate mcd2 = new multiCastDelegate(MCD.Print);
            multiCastDelegate mcd3 = mcd1 +mcd2;
            multiCastDelegate mcd4 = mcd2 + mcd1;
            multiCastDelegate mcd5 = mcd3 - mcd2;
            multiCastDelegate mcd6 = mcd2 - mcd1;
            multiCastDelegate mcd7 = mcd5 - mcd6;
            multiCastDelegate mcd8 = mcd6 - mcd5;
            mcd1();
            Console.WriteLine();
            mcd2();
            Console.WriteLine();
            mcd3();
            Console.WriteLine();
            mcd4();
            Console.WriteLine();
            mcd5();
            Console.WriteLine();
            mcd6();
            Console.WriteLine();
            mcd7();
            Console.WriteLine();
            mcd8();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
