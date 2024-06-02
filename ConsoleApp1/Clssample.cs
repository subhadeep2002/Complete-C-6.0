using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clssample
    {
        int i;
        static int j;
        public Clssample() 
        {
            i = 100;
        }
        static Clssample()
        {
            j = 100;
        }
        public void display()
        {
            Console.WriteLine("value if i is " + i);
            i++;
            Console.WriteLine("value if j is" + j);
            j++;
        }
    }
    class Clsstaticconstructor
    {
        static void Main(string[] args)
        {
            Clssample obj1= new Clssample();
            obj1.display();
            Clssample obj2 = new Clssample();
            obj2.display();
            Clssample obj3 = new Clssample();
            obj3.display();
            Console.ReadLine();
        }
    }
}
