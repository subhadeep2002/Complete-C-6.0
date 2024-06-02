using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsProperty
    {
        static void Main(string[] args)
        {
            Employee9 obj1 = new Employee9();
            Console.WriteLine("Enter employee details : ");
            obj1.PEmpid = int.Parse(Console.ReadLine());
            obj1.PEname= Console.ReadLine();
            obj1.PEaddress= Console.ReadLine();
            obj1.PEage = int.Parse((string)Console.ReadLine());

            Console.WriteLine("Employee details are : ");
            Console.WriteLine("Employee id is : "+ obj1.PEmpid);
            Console.WriteLine("Employee name is : " + obj1.PEname);
            Console.WriteLine("Employee address is : " + obj1.PEaddress);
            Console.WriteLine("Employee address is : " + obj1.PEage);
            Console.Read();
        }
    }
}