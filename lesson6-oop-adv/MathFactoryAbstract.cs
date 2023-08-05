using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_oop_adv
{
    abstract internal class MathFactoryAbstract
    {

        public bool CanRun { get; set; }
        public void PrintMe()
        {
            Console.WriteLine(  "hello world");
        }
        // abstract method
        public abstract void display1();

        public virtual int Calculate()
        {
            return 10;
        }
    }

    internal class MathChildA : MathFactoryAbstract
    {
        public override void display1()
        {
            throw new NotImplementedException();
        }

        public override int Calculate()
        {
            return 20;
        }
    }
}
