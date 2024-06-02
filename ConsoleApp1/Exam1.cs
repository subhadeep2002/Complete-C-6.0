using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition : " + (num1 + num2));
            Console.WriteLine("Subtraction : " + (num1 - num2));
            Console.WriteLine("Multiplication : " + (num1 * num2));
            Console.WriteLine("Division :" + (num1 / num2));
            Console.WriteLine("Modular :"+ (num1 % num2));
            Console.ReadLine();
        }
    }
}
