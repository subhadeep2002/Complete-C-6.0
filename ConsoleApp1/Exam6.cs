using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Salary :");
            int basic = int.Parse(Console.ReadLine());

            salary s1 = new salary(basic,HRA:12.5f);
            Console.WriteLine("Total Salary : " + s1.CalculateTotalSalary());
            Console.ReadLine();
        }
        class salary
        {
            int Basic;
            float DA, TA, HRA;
            public salary(int Basic, float DA = 12.5f, float TA = 12.5f, float HRA = 10f)
            {
                this.Basic = Basic;
                this.DA = DA;
                this.TA = TA;
                this.HRA = HRA;
            }
            public double CalculateTotalSalary()
            {
                double total = Basic + (Basic * TA / 100) + (Basic * DA / 100) + (Basic * HRA / 100);
                return total;
            }
        }
    }
}
