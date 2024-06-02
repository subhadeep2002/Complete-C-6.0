using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam8
    {
        public delegate void singleCastDelegate();
        public class SCD
        {
            public static void Display()
            {
                Console.WriteLine("Display : Hello");
            }
            public static void Show()
            {
                Console.WriteLine("Show : Hii");
            }
            public void Print()
            {
                Console.WriteLine("Hello C#");
            }
        }
        static void Main(string[] args)
        {
            singleCastDelegate scd1 = SCD.Display;
            scd1();

            scd1=new singleCastDelegate(SCD.Show);
            scd1();

            SCD obj = new SCD();
            scd1 = obj.Print;
            scd1();
            Console.Read();
        }
    }
}
