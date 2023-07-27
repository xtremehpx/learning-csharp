using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            DoSomethingA obj = new DoSomethingA();
            obj.Foo();
            


            Console.ReadLine();


            // scope

            /*
             * 
             *  asdfsad fsa
             *  dasf asf
             *  asfadf
             *  dsaf af 
             * 
             */


            /*
             * 
             *  public    :: cross-project accessible
             *  internal  :: inside current accessible
             *  private   :: only inside current class
             * 
             *   hierarchy:: Class > Method
             */


            {


            }

            do_something_private();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void do_something_private()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void do_something(string a)
        {
            throw new NotImplementedException();
        }

        public static void do_something_public()
        {

        }


        // signature :: name, param

        public void do_something_regular()
        {
            
        }

        public void do_something_regular(string str)
        {

        }

        public int do_something_regular(int str)
        {
            return 10;
        }



        // loop

        public void do_loop()
        {
            var a = 1;
            var b = 2;

            if( a == b)
            {

            } 
            else if( a > b)
            {
                // ...
            }
            else
            {
                // optional                

            }


            var break1 = false;
            var break2 = false;

            for(var i = 0; i< 5; i++)
            {
                Console.WriteLine( "i=" + i );
                for (var j = 0; j < 3; j++)
                {

                    if (i == 1) 
                        break;

                    Console.WriteLine("j=" + i);
                }

                if (i == 3) 
                    break;


            }


            do
            {


                break;

            } while(true); // comment


        }
        


        public int exception_handling()
        {

            try
            {

                // main logic goes here
                // ....
                // 

                throw new Exception("Bad things happened");
            }
            //catch (Exception e)
            //{

            //    // add custom handling logic

            //    // throw; 

            //    Console.WriteLine( "Error: " +  e.Message);

            //}
            finally 
            {
                Console.WriteLine("Finally do anyway " );
            }


            return 0;
        }


    }
}
