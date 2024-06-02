using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            Dictionary<string,object> dt = new Dictionary<string,object>();
            dt.Add("eid", 1234);
            dt.Add("ename", "sai");
            dt.Add("eaddress", "hyd");
            dt.Add("sal", 23400);

            foreach (string key in dt.Keys)
            {
                Console.WriteLine(key + ":" + dt[key]); 
            }
            Console.ReadKey();
        }
    }
}
