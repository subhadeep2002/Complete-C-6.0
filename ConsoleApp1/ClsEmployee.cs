using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsEmployee
    {
        static void Main(string[] args)
        {
            ClsEmp obj1 = new ClsEmp(1234,"sai",46600.00,"hyderabad");
            Console.WriteLine("Employee Details are :");
            Console.WriteLine("Employee no is:" + obj1[0]);
            Console.WriteLine("Employee name is:" + obj1[1]);
            Console.WriteLine("Employee salary is:" + obj1[2]);
            Console.WriteLine("Employee address is:" + obj1[3]);
            Console.WriteLine("Employee age is:" + obj1[4]);
            obj1[1] = "mohan";
            obj1[3] = "sr  nagar";
            Console.WriteLine("Employee Details are :");
            Console.WriteLine("Employee no is:" + obj1[0]);
            Console.WriteLine("Employee name is:" + obj1[1]);
            Console.WriteLine("Employee salary is:" + obj1[2]);
            Console.WriteLine("Employee address is:" + obj1[3]);
            Console.WriteLine("Employee age is:" + obj1[4]);
            Console.Read();
        }
    }
}
