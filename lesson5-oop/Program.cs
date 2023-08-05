using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lesson5_oop.Fibonacci;

namespace lesson5_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class2 7/22/23 S
            //Console.WriteLine("Hello World");
            //Console.ReadLine();
            //class2
            //class3 7/26/23 W
            //while loops
            //int a = 10;
            //do
            //{
            //Console.WriteLine("value of a: {0}", a);
            //a = a + 1;
            //}
            //while (a < 20);
            //while (a < 20) {
            //Console.WriteLine("value of a: {0}", a);
            //a++;
            //
            //if (a > 15)
            //{
            //break;
            //}
            //}
            //for loops
            //for (int a = 10; a < 20; a = a +1)
            //{
            //Console.WriteLine("value of a: {0}", a);
            //}
            //class3
            //class4 7/29/23 S
            int n = 10;
            int m = 0;
            m = n + 1;

            // use normal Function inside local program
            var f = Fibonnaci(m);
            Console.WriteLine("Fibonacci number is {0}", f);


            // use OOP class

            // default constructor
            //create a new Object of Fibonacci
            Fibonacci fb = new Fibonacci();
            //Console.WriteLine( "Default value of Number: " + fb.Number);
            //Console.WriteLine( string.Format("using string.Format: :Default value of Number: {0}, {1}", fb.Number, 2) );

            // access member Number
            // assign value
            fb.Number = 10;
            Console.WriteLine("Assigned value of Number: " + fb.Number);

            Console.WriteLine(  "Dynamic Programming");
            fb.CalculateDpp(10);

            Console.WriteLine("Recursion");
            fb.CalculateRecursion(10);

            //// parametric constructor
            //fb = new Fibonacci(13);
            //Console.WriteLine("Default value of Number: " + fb.Number);


            //class4 7/29/23 S
            Console.ReadLine();
        }

        // for, while, recursive, dynamic programming
        public static int Fibonnaci(int m)
        {
            int f0 = 0;
            int f1 = 1;
            int f = 0;

            for (int a = 2; a < m; a = a + 1)
            {
                f = f0 + f1;
                f0 = f1;
                f1 = f;
            }

            return f;
        }
    }
}
