using commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_loops
{
    internal class Program
    {

        const string AB = "AD";
        private const string V = "A";
        readonly string DD = "CC";

        static void Main(string[] args)
        {
            // call commons library PrintStatment()
            Utility.PrintStatement("Hello World");

            
            char f = 'a';

            string ff = new string(f, 20); 

            Utility.PrintStatement(ff);

            
            // C# 7::  tuple
            (int, string) person = (10, "John Smith");
            (int, int, string) person2 = (10, 5, "John Smith");

            // when to use?
            // 1. database records
            // 2. function has multiple returns 

            // or using existing technology
            Dictionary<int, string> dicts = new Dictionary<int, string>();
            MyCustomerType abc = new MyCustomerType() { id = 1, val = 2, strings = "GGG" };


            // C# 8:: switch


            // Homework
            Fibonacci fib = new Fibonacci();
            var result = fib.fibonacci(10);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
