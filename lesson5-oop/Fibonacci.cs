namespace lesson5_oop
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
    }
}
