using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee6
    {
        protected int Empid;
        protected string Ename;
        string Eaddress;
        int Eage;

        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee Details");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.Eaddress = Console.ReadLine();
            this.Eage = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is:" + this.Empid);
            Console.WriteLine("EmpName is:" + this.Ename);
            Console.WriteLine("EmpAaddress is:" + this.Eaddress);
            Console.WriteLine("EmpAge is:" + this.Eage);
        }
    }
    class Manager : Employee6
    {
        double CA, Bonus;
        public new void GetEmpData()
        {
            base.GetEmpData();
            Console.WriteLine("Enter Manager Details");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            base.DisplayEmpData();
            Console.WriteLine("Manager Details are");
            Console.WriteLine("Manager Id is:" + this.Empid);
            Console.WriteLine("Manager Name is:" + this.Ename);
            Console.WriteLine("Manager CA is:" + this.CA);
            Console.WriteLine("Manager Bonus is:" + this.Bonus);
        }
    }
    class ClsOverride1
    {
        static void Main(string[] args)
        {
            Manager obj1 = new Manager();
            obj1.GetEmpData();
            obj1.DisplayEmpData();
            Console.ReadLine();
        }
    }
}
