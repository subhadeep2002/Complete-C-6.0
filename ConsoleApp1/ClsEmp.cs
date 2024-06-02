using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsEmp
    {
        int eno;
        string ename;
        double salary;
        string eaddress;

        public ClsEmp (int eno, string ename, double salary, string eaddress)
        {
            this.eno = eno;
            this.ename = ename;
            this.salary = salary;
            this.eaddress = eaddress;
        }
        public object this[int index]
        { 
            get 
            { 
                if (index==0)
                    return eno; 
                else if(index==1)
                        return ename;
                else if(index==2) 
                    return salary;
                else if(index==3)
                    return eaddress;
                return null;
            }
            set
            {
                if (index == 0)
                    eno = (int)value;
                else if(index ==1)
                    ename = (string)value;
                else if(index == 2)
                    salary = (double)value;
                else if(index == 3)
                    eaddress = (string)value;
            }
        }
    }
}
