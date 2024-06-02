using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter two number");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Result is:" + c);
            }
            catch (Exception msg)
            {
                    Console.WriteLine(msg.Message);
            }
            //catch (FormatException msg)
            //{
            //    Console.WriteLine(msg.Message);
            //}
            finally 
            { 
                Console.WriteLine("code is executed"); 
            }
            Console.Read();
        }
    }
}
