using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Property1
    {
        static void Main(string[] args)
        {
            Arithmetic obj1= new Arithmetic();
            Console.WriteLine("Enter two umbers");
            obj1.Pnum1 = int.Parse(Console.ReadLine());
            obj1.Pnum2 = int.Parse(Console.ReadLine());
            obj1.Add();
            Console.WriteLine("Sum is :" + obj1.Presult);
            obj1.Sub();
            Console.WriteLine("Sub is :" + obj1.Presult);
            obj1.Mul();
            Console.WriteLine("Mul is :" + obj1.Presult);
            obj1.Div();
            Console.WriteLine("Div is :" + obj1.Presult);
            Console.Read();
        }
    }
}
