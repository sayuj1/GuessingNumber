using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumber
{

    class Program
    {
        /// <summary>
        /// A Simple Guessing Number Game, Where user guess a number.
        /// </summary>
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = GuessingNumb.MainMenu();
                Console.WriteLine("Hit the Enter key...");
            }

            Console.ReadKey();
        }
    }
/// <summary>
/// Guessing Number Main menu display
/// </summary>
    class GuessingNumb
    {
        public static bool MainMenu()
        {
            Console.WriteLine("Press 1 for guessing number game");
            Console.WriteLine("Press 2 for clearing the screen");
            Console.WriteLine("Press 3 for exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                GuessNumbers();
                return true;
            }
            else if (result == "2")
            {
                Console.Clear();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Exiting....");
                return false;
            }
            else
            {
                Console.WriteLine("Select a valid input");
                return true;
            }
        }
        
        
        //Method for guessing number
        private static void GuessNumbers()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");
            //Random Number generation
            Random random = new Random();
            int randomNum = random.Next(1, 10);

            int guesses = 0;
            bool incorrect = true;
            //Checking user guessed correct number or not
            do
            {
                Console.WriteLine("Guess a number between 1 and 9");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNum.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Incorrect number! Try again ;)");
            } while (incorrect);

            if (guesses == 1)
                Console.WriteLine($"Correct! You got it in {guesses} guess :)");
            else
                Console.WriteLine($"Correct! You got it in {guesses} guesses :)");
            Console.ReadKey();
        }
    }
}
