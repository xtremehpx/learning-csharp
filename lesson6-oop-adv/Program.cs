using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_oop_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathFactoryAbstract factory = new MathFactoryAbstract();
            //factory.PrintMe();

            MathChildA mathChildA = new MathChildA();
            Console.WriteLine(mathChildA.Calculate());



            AnimalFactory parent = new AnimalFactory();
            parent.HasFur = true;
            parent.NumberOfLegs = 5;
            Console.WriteLine("num of legs running: " + parent.Run());

            //Dog dog = new Dog();
            //dog.HasFur = false;
            //dog.NumberOfLegs = 4;
            //Console.WriteLine("num of legs running: " + dog.Run());

            // interface invokation must be a concrete type
            IAnimalFactory animalFactory = new AnimalFactory();

            IAnimalFactory dogs = new Dog();

            dogs.Run();


            Console.ReadLine();

        }
    }
}
