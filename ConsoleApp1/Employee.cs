using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public void GetEmpData()//Method - reusable piece of code
        {
            Console.WriteLine("Enter Employee Details");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.Eaddress = Console.ReadLine();
            this.Eage = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is:" + this.Empid);
            Console.WriteLine("EmpName is:" + this.Ename);
            Console.WriteLine("EmpAaddress is:" + this.Eaddress);
            Console.WriteLine("EmpAge is:" + this.  Eage);
        }
    }
    class ClsConsume
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of EMployees");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++) 
            {
                Employee obj1 = new Employee();
                obj1.GetEmpData();
                obj1.DisplayEmpData();//member access operator
            }
            
            Employee obj2 = new Employee();
            
            obj2.GetEmpData();
            obj2.DisplayEmpData();
            Console.ReadLine();
        }
    }
}
