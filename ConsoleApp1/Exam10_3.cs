using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam10_3
    {
        class Parent
        {
            public void M()
            {
                Console.WriteLine("Parent Class");
            }
        }
        class Child:Parent
        { 
            public void M()
            {
                Console.WriteLine("Child Class");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reference Variable : Parent Class && Object : Parent Class");
            Parent parent = new Parent();
            parent.M();

            Console.WriteLine();
            Console.WriteLine("Reference Variable : Child Class && Object : Child Class");
            Child child = new Child();
            child.M();
            Console.ReadLine();
        }
    }
}
