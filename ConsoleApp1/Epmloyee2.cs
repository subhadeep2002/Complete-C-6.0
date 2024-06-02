using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Epmloyee2
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;
        public Epmloyee2(int empid,string s1,string s2,int Ag)
        {
            this.Empid = empid;
            this.Ename = s1;
            this.Eaddress = s2;
            this.Eage = Ag;
        }
        public Epmloyee2(int empid, string s1)
        {
            this.Empid = empid;
            this.Ename = s1;
        }
        public Epmloyee2()
        {
            this.Empid = 678;
            this.Ename = "manoj";
            this.Eaddress = "hyd";
            this.Eage = 33;
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
    class ClsParameter
    {
        static void Main(string[] args)
        {
            Epmloyee2 obj1 = new Epmloyee2(1234,"sai","hyd",45);
            Epmloyee2 obj2 = new Epmloyee2(3456, "ram", "sr nagar", 34);
            Epmloyee2 obj3 = new Epmloyee2();
            Epmloyee2 obj4 = new Epmloyee2(7890,"ganesh");
            obj1.Displayempdata();
            obj2.Displayempdata();
            obj3.Displayempdata();
            obj4.Displayempdata();
            Console.Read();
        }
    }
}
