using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_oop_adv
{


    /// <summary>
    /// Concrete implementation of IAnaimalFactory interface
    /// </summary>
    public class AnimalFactory : IAnimalFactory
    {
        public int NumberOfLegs { get; set; }
        public bool HasFur { get; set; }

        public virtual int Run()
        {
            return NumberOfLegs;
        }
    }


    public class Dog : AnimalFactory
    {
        public override int Run()
        {
            return NumberOfLegs * 2;
        }
    }
}
