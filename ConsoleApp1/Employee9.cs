using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee9
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public int PEmpid
        { 
            set { Empid = value; }
            get { return Empid; }
        }   
        public string PEname
        {
            set { Ename = value; }
            get { return Ename; }
        }
        public string PEaddress
        {
            set { Eaddress = value; }
            get { return Eaddress; }
        }
        public int PEage
        {
            set { Eage = value; }
            get
            {
                return Eage;
            }   
        }
    }
}
