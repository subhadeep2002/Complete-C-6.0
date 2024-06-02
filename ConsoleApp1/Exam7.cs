using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam7
    {
        static void Main(string[] args)
        {
            try
            {

            int num1 = 20;
            int num2 = 10;
            int num3 = 0;

            int div1 = num1 / num2;
            Console.WriteLine(div1);

            int div2 = num2 / num3;
            Console.WriteLine(div2);
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("Value Cannot be Divided by Zero");
            }
            Console.ReadLine();
        }
    }
}
