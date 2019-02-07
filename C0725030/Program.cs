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
            //a.PlayingWithForLoops();

            var b = new BirthdayParty();
            b.setupPartyList();
            Console.WriteLine(b.printPartyList());
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

            //Question 2-3 will run for 10 times (for loop or while loop)
            while (MyMethod())
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

    //Question about Nodes + Linked List
    class Dog
    {
        public Dog(string name, string breed)
        {
            dogName = name;
            dogBreed = breed;
        }

        public string dogName;
        public string dogBreed;
        public Dog nextDog;
        public Dog previousDog;
    }
    class BirthdayParty
    {
        public Dog Peanut;
        public Dog Fifi;
        public Dog Clarence;
        public Dog Giselle;
        public Dog Lulu;
        public Dog Roy;

        public Dog head;
        public Dog tail;
        public Dog temporary;

        public void setupPartyList()
        {
            Peanut = new Dog("Peanut", "Bichon");
            Fifi = new Dog("Fifi", "Poodle");
            Clarence = new Dog("Clarence", "German Sheppard");
            Giselle = new Dog("Giselle", "Border Collie");
            Lulu = new Dog("Lulu", "Shitzu");
            Roy = new Dog("Roy", "Beagle");

            Peanut.previousDog = null;
            Peanut.nextDog = Fifi;

            Fifi.previousDog = Peanut;
            Fifi.nextDog = Clarence;

            Clarence.previousDog = Fifi;
            Clarence.nextDog = Giselle;

            Giselle.previousDog = Clarence;
            Giselle.nextDog = Lulu;

            Lulu.previousDog = Giselle;
            Lulu.nextDog = Roy;

            Roy.previousDog = Lulu;
            Roy.nextDog = null;

            head = Peanut;
            tail = Roy;
        }
        //Print the party list from the head
        //public string printPartyList()
        //{
        //    string inviteList = "*--";
        //    temporary = head;

        //    while (temporary.nextDog != null)
        //    {      
        //        inviteList += temporary.dogName + " * --- * ";
        //        temporary = temporary.nextDog;
        //    }
        //    inviteList += temporary.dogName + " * --- * ";
        //    return inviteList;
        //}

        //Print the party list from the end
        public string printPartyList()
        {
            string inviteList = "*--";
            temporary = tail;

            while (temporary.previousDog != null)
            {
                inviteList += temporary.dogName + " * --- * ";
                temporary = temporary.previousDog;
            }
            inviteList += temporary.dogName + " * --- * ";
            return inviteList;
        }
    }
}
