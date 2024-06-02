using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee3
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        private Employee3()
        {
            this.Empid = 1234;
            this.Ename = "Sai";
            this.Eaddress = "hyd";
            this.Eage = 34;
        }
        private void Displayempdata()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is:" + this.Empid);
            Console.WriteLine("Empname is:" + this.Ename);
            Console.WriteLine("EmpAddress is:" + this.Eaddress);
            Console.WriteLine("Empage is:" + this.Eage);
        }
        static void Main(string[] args)
        {
            Employee3 obj1 = new Employee3();
            obj1.Displayempdata();
            Console.Read();
        }
    }
}
