using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Branch1
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
    interface Employee7
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    class Manager1:Branch1,Employee7
    {
            int Empid;
            string Ename;
            double CA, Bonus;
        public void GetEmpData() 
        {
            Console.WriteLine("Enter Manager Details");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData() 
        {
            Console.WriteLine("Manager Details are");
            Console.WriteLine("Manager Id is:" + this.Empid);
            Console.WriteLine("Manager Name is:" + this.Ename);
            Console.WriteLine("Manager CA is:" + this.CA);
            Console.WriteLine("Manager Bonus is:" + this.Bonus);
        }
    }
    class ClsMultipleInheritance
    {
        static void Main(string[] args)
        {
            Manager1 obj1 = new Manager1();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.DisplayBdata();
            obj1.DisplayEmpData();
            Console.ReadLine();
        }
    }
}
