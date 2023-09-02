using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace lesson10_modularizing
{
    public class Fibonacci
    {
        // constructor
        public Fibonacci()
        {
            // default constructor
        }

        public Fibonacci(int num)
        {
            Number = num;                
        }

        // simple getter / setter
        // public int MyProperty { get; set; }

        private int _number = 0;
        public int Number {
            get
            {
                
                return _number;
            }

            set
            {
                if (value < 10)
                {
                    _number = 0;
                }
                else
                {
                    _number = value * 10;
                }
            }
        }


        

        public const int F0 = 0;
        public const int F1 = 1;

        public int Calculate()
        {

            int f0 = 0;
            int f1 = 1;
            int f = 0;

            for (int a = 2; a < Number; a = a + 1)
            {
                f = f0 + f1;
                f0 = f1;
                f1 = f;
            }

            return f;
        }


        // unit test

        //



        // OOP other topics

        // inheritance :: child class and parent class relation

        // abstract class

        // interface class 


        public int CalculateRecursion(int n) 
        {
            if(n==0) return 0;
            if(n==1) return 1;

            Debug.WriteLine( "Calculate " + n );

            return CalculateRecursion(n - 1) + CalculateRecursion(n - 2);
        }

        // key - value pair, hash map
        // Algorithm efficiency:: Big-O O(n), O(n^2)
        // Hash Map / Hash Table / Dictionary :: use key value - O(1) 
        Dictionary<int, int> dict = new Dictionary<int, int>(); 
        public int CalculateDpp(int n)
        {
            if(n==0) return 0;
            if(n==1) return 1;

            Debug.WriteLine("Calculate " + n);

            var fn1 = dict.ContainsKey(n - 1) ? dict[n-1] : CalculateDpp(n - 1);
            var fn0 = dict.ContainsKey(n - 2) ? dict[n - 2] : CalculateDpp(n - 2);

            dict[n] = fn1 + fn0;

            return dict[n];
        }
    }
}
