using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class DoSomethingA
    {
        public void Foo() 
        { 
            Program.do_something_public();

            Program a = new Program(); // a new object instance 
            //a.do_something_regular();
            

            a.exception_handling();

            a.do_loop();

        }
    }
}
