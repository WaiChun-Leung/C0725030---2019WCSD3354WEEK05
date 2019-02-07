using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030
{
    class Program
    {
        static void Main(string[] args)
        {
            //WEEK 5
            //Console.WriteLine("Hello World!");

            //Question 2-1 (create object classes)
            var a = new TestOuestion2();
            a.PlayingWithForLoops();

        }
    }
    class TestOuestion2
    {
        public int myFavoriteVariable = 0;
        public void PlayingWithForLoops()
        {
            //Question 2-1 (it will loop forever)
            //for ( ; ; )
            //{
            //    Console.WriteLine("I am in the for loop");
            //}

            //Question 2-2
            //Write a For Loop to Add 10 Numbers
            //for ( ; false ; )     //HOTKEY is double click Tab
            //    //false will run, but won't show anything
            //    //TRUE infinite loop
            //    //varibale initialize + check the condition + increasement
            //{
            //    Console.WriteLine("I am in the for loop");
            //}

            //Question 2-3 will run for 10 times
            for (; MyMethod();) 
            {
                if (myFavoriteVariable > 10)
                {
                    Console.WriteLine("I am so out of here");
                    break;
                }
                Console.WriteLine("Oh no I have to go through this stupid loop again... ");
            }
        }
        public bool MyMethod()
        {
            myFavoriteVariable++;
            return true;
        }
        //public bool MyMethod() //is infinite loop
        //{
        //    return true;
        //}
    }
}
