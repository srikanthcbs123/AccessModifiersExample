using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiersExample;
using Tcs.BankodAmerica.Models;
namespace AccessModifiersExample
{
    public class Class5
    {
       public void samplecheck()
        {
            Sipdashboard obj=new Sipdashboard();
            obj.Sipdashboard_e = 1000;//we can access only public member in other projects.
            //private,protected and protected internal,internal members directly we can't access in other projects
        }
    }
}
