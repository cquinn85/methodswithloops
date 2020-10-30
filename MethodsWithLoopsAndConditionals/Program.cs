using System;
using System.Dynamic;
using System.Linq;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            ByThrees();
            Console.WriteLine(AreEqual(2, 10));
            Console.WriteLine("******************");
            Console.WriteLine("Pick a number:");
            OddEven();
            Console.WriteLine("******************");
            Console.WriteLine("Pick another number:");
            PositveOrNegative();
            Console.WriteLine("******************");
            Console.WriteLine("******************");
            Console.WriteLine("What is your age:");
            LetsVote();
            Console.WriteLine("******************");
            Console.WriteLine("******************");
            Console.WriteLine("Give me a number between 10 and -10:");
            var inBetween = int.Parse(Console.ReadLine());
            Range(inBetween);
            Console.WriteLine("******************");
            Console.WriteLine("******************");
            Console.WriteLine("Give me numbers to multiply:");
           
            Multiply();
        }

      

        //Write a method that will print to the console 
        //all numbers 1000 through - 1000.
        public static void PrintThousand()
        {
          for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print 
        //to the console numbers 3 through 999 by 3 each time.

        public static void ByThrees()
        {
            for(int j = 3; j <= 999; j += 3)
            {
                Console.WriteLine(j);
            }
        }

        //Write a method to 
        //accept two integers as parameters 
        //and check whether they are equal or not.

        public static bool AreEqual(int a, int b)
        {
            
            //how do i determine if two numbers are equal?
            if (a == b)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        //Write a method to check whether 
        //a given number is even or odd.

        public static void OddEven()
        {
            var num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        //Write a method 
        //to check whether a given number 
        //is positive or negative.

        public static void PositveOrNegative()
        {
            var num1 = int.Parse(Console.ReadLine());
            
            if(num1 < 0)
            {
                Console.WriteLine("You have a negative number.");
            }
            else
            {
                Console.WriteLine("Your number is positive!");
            }
        }

        //Write a method to read the age of a candidate 
        //and determine whether they can vote. Hint: use Parse()

        public static void LetsVote()
        {
            var voterAge = int.Parse(Console.ReadLine());

            if(voterAge >= 18)
            {
                Console.WriteLine("You are of voting age.");
            }
            else
            {
                Console.WriteLine("You are to young to vote.");
            }
        }

        //Write a method to check if an integer (from the user) 
        //is in the range -10 to 10.

        public static bool Range(int a)
        {
          if(a <= 10 && a >= -10)
            {
                Console.WriteLine("Your number is within the range");
                return true;
            }
            else
            {
                Console.WriteLine("Your number is out of the range");
                return false;
            }
        }

        //Write a method 
        //to display the multiplication table(from 1 to 12) 
        //of a given integer.

        public static void Multiply()
        {
            var j = 0;
            var n = int.Parse(Console.ReadLine()); ;

            for(j = 1; j <= 12; j++)
            {
                Console.WriteLine("{0} x {1}",n,j, n*j);
            }
        }

    }
}
