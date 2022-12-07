using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Printing1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void EqualOrNot()
        {
            Console.WriteLine("Enter two numbers. Lets start with first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                ;
                Console.WriteLine("They are equal");
            }

            else
            {
                Console.WriteLine("They are NOT");
            }


        }

        public static void EqualOrNotAnotherWay(int a, int b)
        {


            if (a == b)
            {
                ;
                Console.WriteLine("They are equal");
            }

            else
            {
                Console.WriteLine("They are NOT");
            }


        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("It is even");
            }
            else
            {
                Console.WriteLine("It is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int a)
        {
            if (a >= 1)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VotingEligiblity()
        {
            Console.WriteLine("Enter your age");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 21)
            {
                Console.WriteLine("You are eligble to vote.");
            }
            else
            {
                Console.WriteLine("You are too young to vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void NumberCheckingOne()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= -10 && a <= 10)
            {
                Console.WriteLine("You are in range");
            }
            else { Console.WriteLine(" You are not in range"); }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($" {i} x {num} = {num * i} ");
            }
        }
            //Call the methods to test them in the Main method below
            static void Main(string[] args)
            {
                Program.Printing1000();
                Program.PrintByThree();
                Program.EqualOrNot();
                Program.EqualOrNotAnotherWay( 9,  9);
                Program.EvenOrOdd(8);
                Program.PositiveOrNegative(-9);
                Program.VotingEligiblity();
                NumberCheckingOne();
                MultiplicationTable(2);
            }
        }
    }
