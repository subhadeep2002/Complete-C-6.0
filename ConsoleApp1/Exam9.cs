using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //2
    //class AgeException : Exception
    //{
    //    public override string Message
    //    {
    //        get { return "Age Custom Exception Raised : You are a senior citizen, you can not work in any company"; }
    //    }
    //}
    internal class Exam9
    {
        class EvenNumber : Exception
        {
            public override string Message
            {
                get { return "Even Number Custom Exception Raised : The given number is even number"; }
            }
        }
        static void Main(string[] args)
        {
            int number;
            try
            {
                Console.Write("Enter number : ");
                number = int.Parse(Console.ReadLine());

                if(number%2!=0)
                {
                    Console.WriteLine("Odd");
                }
                else
                {
                    throw new EvenNumber();
                }
            }
            catch(EvenNumber ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
            //2
            //int age;
            //try
            //{
            //    Console.Write("Enter your Age : ");
            //    age = int.Parse(Console.ReadLine());
            //    if (age > 60)
            //    {
            //        throw new AgeException();
            //    }
            //}
            //catch(AgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            //1
            //int num1, num2, div;
            //try
            //{
            //    Console.Write("Enter Value for Num1 :");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Value for Num2 :");
            //    num2 = int.Parse(Console.ReadLine());

                    //    div = num1 / num2;
                    //    Console.WriteLine("Div :" + div);
                    //}
                    //catch(DivideByZeroException de)
                    //{
                    //    Console.WriteLine("DivideByZeroException Exception Message"+de.Message);
                    //}
                    //catch(FormatException fe)
                    //{
                    //    Console.WriteLine("FormatException Exception Message" + fe.Message);
                    //}
                    //Console.Read();

                    //2

        }
    }
}
