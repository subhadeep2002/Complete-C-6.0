using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class Class9
    {
        //x developer code

        int id;
        string name;
        public void GetData()
        {
            Console.WriteLine("Enter Employee id");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            this.name = Console.ReadLine();
        }
    }
}
