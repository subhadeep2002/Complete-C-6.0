using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            string n1 = Console.ReadLine();
            int num1;
            while(!int.TryParse(n1, out num1))
            {
                Console.Write("Re-Enter Number 1 :");
                n1 = Console.ReadLine();
            }

            Console.Write("Enter Number 2 :");
            string n2 = Console.ReadLine();
            int num2 = 0;
            while (!int.TryParse(n2, out num2) || num2 == 0) 
            {
                Console.WriteLine("Re-Enter Number 2 :");
                n2 = Console.ReadLine();
            }
            Console.WriteLine("**********************************");
            Console.WriteLine("Number 1 is :" + num1);
            Console.WriteLine("Number 2 is :" + num2);
            Console.WriteLine("**********************************");
            Console.WriteLine("Addition : " + (num1 + num2));
            Console.WriteLine("Subtraction :" + (num1 - num2));
            Console.WriteLine("Multipliction :" + (num1 * num2));
            Console.WriteLine("Division :" + (num1 / num2));
            Console.WriteLine("Mod :" + (num1 % num2));
            Console.WriteLine("************************************");
            Console.ReadLine();
        }
    }
}
