using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee1//internal class can be accessible anywhere in same application
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public Employee1() 
        {
            this.Empid = 1234;
            this.Ename = "Sai";
            this.Eaddress = "hyd";
            this.Eage = 34;
        }
        public void Displayempdata()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is:" + this.Empid);
            Console.WriteLine("Empname is:"+this.Ename);
            Console.WriteLine("EmpAddress is:"+this.Eaddress);
            Console.WriteLine("Empage is:"+this.Eage);
        }
    }
    class ClsUDConstructor
    {
        static void Main(string[] args) 
        {
            Employee1 obj1 = new Employee1();
            obj1.Displayempdata();
            Console.ReadLine(); 
        }
    }
}
