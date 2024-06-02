using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Branch
    {
        int Bcode;
        string Bname;
        string Baddress;

        public void GetBData()
        {
            Console.WriteLine("Enter Branch Details");
            this.Bcode = int.Parse(Console.ReadLine());
            this.Bname = Console.ReadLine();
            this.Baddress = Console.ReadLine();
        }
        public void DisplayBdata()
        {
            Console.WriteLine("Branch Details are :");
            Console.WriteLine("Branch code is :" + this.Bcode);
            Console.WriteLine("Branch name is :" + this.Bname);
            Console.WriteLine("Branch address is :" + this.Baddress);
        }
    }
    class Employee5 : Branch
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
            Console.WriteLine("EmpAge is:" + this.Eage);
        }
    }
    class Employeesalary:Employee5
    {
        double Basic, DA, HRA, Gross;
        public void Getsal()
        {
            Console.WriteLine("Enter Basic Salary:");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void Calculate() 
        {
            this.DA = this.Basic * 0.06;
            this.HRA = this.Basic * 0.4;
            this.Gross = this.Basic + this.DA + this.HRA;
        }
        public void Displaysal()
        {
            Console.WriteLine("Employee salary details");
            Console.WriteLine("Basic is :" + this.Basic);
            Console.WriteLine("DA is :" + this.DA);
            Console.WriteLine("HRA is :" + this.HRA);
            Console.WriteLine("Gross is :" + this.Gross);
        }
    }
    class ClsInheritance
    {
        static void Main(string[] args)
        {
            //Employee5 obj1 = new Employee5();
            //obj1.GetBData();
            //obj1.GetEmpData();
            //obj1.DisplayBdata();
            //obj1.DisplayEmpData();
            Employeesalary obj1 = new Employeesalary();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.Getsal();
            obj1.Calculate();
            obj1.DisplayBdata();
            obj1.DisplayEmpData();
            obj1.Displaysal();
            Console.Read();
        }
    }
}
