using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter Two Number : ");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum is : "+c);
            Console.Read();
        }
    }
}
