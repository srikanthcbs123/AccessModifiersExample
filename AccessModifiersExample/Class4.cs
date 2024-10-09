using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcs.BankodAmerica.Models;
namespace AccessModifiersExample
{
    //Child classes at other project
    //accessmodifier class childclassname:Parentclassname
    internal class Class4 : Sipdashboard
    {
        public void Method5()
        {
            Sipdashboard_b = 100;//protected member we can access in other projects of child class
            Sipdashboard_d = 111;//protected internal member we can access in other projects of child class
            Sipdashboard_e = 200;//public member we can access any where.
        }
    }
}
//private int Sipdashboard_a; //private member
//protected int Sipdashboard_b; //protected member
//internal int Sipdashboard_c; //internal member
//protected internal int Sipdashboard_d; //protected internal member
//public int Sipdashboard_e; //public member