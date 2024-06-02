using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ToooldException:Exception
    {
        public ToooldException(string message):base(message) 
        { 
        }

    }
    internal class TooyoungException:Exception
    {
        public TooyoungException(string message):base(message) 
        {
        }
    }
    class Exception1
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                if (age >= 60)
                {
                    throw new ToooldException("Age should not be 60 or more");
                }
                else if (age <= 16)
                {
                    throw new TooyoungException("Age should not be 16 or below");
                }
                else
                {
                    Console.WriteLine("You are eligible to take policy");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
