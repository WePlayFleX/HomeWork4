using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs = System.Console;
using cv = System.Convert;


namespace HomeWork4
{
    class HomeWork4
    {
        public static void Main(string[] args)
        {
            //Task1
            cs.WriteLine("Enter the number: ");
            int number = int.Parse(cs.ReadLine());
            cs.WriteLine("Sum of digits of a number " + number + " is equal to: " + NumberLogic.NumberSum(number));
            cs.WriteLine("Product of the digits of a number " + number + " equals: " + NumberLogic.NumberProd(number));

            //Task2
            int Eagle = 0;
            int Tails = 0;
            cs.WriteLine("\n\nEnter the number of coin tosses: ");
            int coinToss = cv.ToInt32(cs.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < coinToss; i++)
            {
                var a = rand.Next(0, 2);
                if (a == 0)
                {
                    Eagle++; 
                }
                else 
                {
                    Tails++;
                }
            }
            cs.WriteLine("The eagle fell " + Eagle + " out once, but tails fell " + Tails + " once!");

            //Task3
            string msg = string.Empty;
            cs.WriteLine("\n\nEnter a number to check: ");
            number = cv.ToInt32(cs.ReadLine());

            bool result = PrimeNumber.NumberLogic(number);
            msg = result ? "It's a prime number! " : "This is not a prime number( ";

            cs.WriteLine(msg);


            //Task4
            cs.WriteLine("\n\nEnter a four-digit number: ");
            number = cv.ToInt32(cs.ReadLine());

            result = Subsequence.AscendingSequence(number);
            msg = result ? "This is an ascending sequence! " : "This is not an ascending sequence( ";

            cs.WriteLine(msg);


            //Task5
            cs.WriteLine("\n\nEnter a natural number: ");
            number = cv.ToInt32(cs.ReadLine());

            result = PerfectNumber.PerfectCheck(number);
            msg = result ? "Your number is PERFECT number! " : "Your number is NOT perfect number. ";

            cs.WriteLine("*** Checking for a perfect number *** \n" +
                         "Input your number: " + number + "\n" + msg);

            cs.ReadKey();
        }
    }
}
