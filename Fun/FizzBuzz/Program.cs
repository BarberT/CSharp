using System;

namespace FizzBuzz
{
    public class Functions
    {
        static void FB(int player)
        {
            string word = "";

            if (player % 3 == 0)
            {
                word = "fizz";
            }
            if (player % 5 == 0)
            {
                word += "buzz";
            }
            if(string.IsNullOrEmpty(word))
            {
                word = player.ToString();
            }

            Console.WriteLine("Result is: " + word);
        }

        public static int GetNumericInput()
        {
            int val = 0;
            string sVal;
            do
            {
                Console.WriteLine("please enter the Number For Fizz-Buzz");
                sVal = Console.ReadLine();
            }
            while (!checkNumeric(sVal));

            val = Convert.ToInt32(sVal);
            FB(val);
           
            return val;
        }
        static bool checkNumeric(string arg)
        {
            // Try to convert the input arguments to numbers. This will throw
            // an exception if the argument is not a number.
            int num;
            bool test = int.TryParse(arg, out num);
            if (!test)
            {
                Console.WriteLine("Please enter a numeric argument.");
            }

            return test;
        }
    }
    class Program
    {

        static public bool PlayAgain()
        {
            while (true) // Continue asking until a correct answer is given.
            {
                Console.Write("Do you want to play again [Y/N]?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    return true;
                if (answer == "N")
                    return false;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                FizzBuzz.Functions.GetNumericInput();
            }
            while (PlayAgain());

            // BASIC CONCEPT FOR FIZZBUZZ ---------------------------------------------------
            //int player = 1;
            //string word = "";
            //if (player % 3 == 0)
            //{
            //    word = "fizz";
            //}
            //if (player % 5 == 0)
            //{
            //    word += "buzz";
            //}
            //if(string.IsNullOrEmpty(word))
            //{
            //    word = player.ToString();
            //}
            //Console.WriteLine(word);
            // BASIC CONCEPT FOR FIZZBUZZ ---------------------------------------------------

        }
    }
}
