using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee4
    {

        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public Employee4()
        {
            this.Empid = 1234;
            this.Ename = "Sai";
            this.Eaddress = "hyd";
            this.Eage = 34;
        }
        public Employee4(Employee4 objTemp)
        {
            this.Empid = objTemp.Empid;
            this.Ename = objTemp.Ename;
            this.Eaddress = objTemp.Eaddress;
            this.Eage= objTemp.Eage;
        }
        public void Displayempdata()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is:" + this.Empid);
            Console.WriteLine("Empname is:" + this.Ename);
            Console.WriteLine("EmpAddress is:" + this.Eaddress);
            Console.WriteLine("Empage is:" + this.Eage);
        }

    }

    class Clscopyconstructor
    {
        static void Main(string[] args)
        {
            Employee4 obj1 = new Employee4();
            Employee4 obj2 = new Employee4(obj1);
            obj1.Displayempdata();
            obj2.Displayempdata();
            Console.Read();
        }
    }
}
