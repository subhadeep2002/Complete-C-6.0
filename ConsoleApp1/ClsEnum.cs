using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsEnum
    {
        //enum level
        //{
        //    Low,
        //    Medium, 
        //    High
        //}
        //static void Main(string[] args)
        //{
        //    level myvalue = level.High;
        //    Console.WriteLine("Level is :"+myvalue);
        //    Console.Read();

        //}
        enum month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            int m = (int)month.March;
            Console.WriteLine(m);
            Console.Read();
        }
    }
}
