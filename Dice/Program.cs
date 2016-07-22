using System;
/// <summary>
/// Name: Mohamoud Mohamed
/// student#:300435435
/// Assigment 4 part A
/// version 1.1
/// </summary>
namespace Dice
{
    class Program
    {   /// <summary>
    /// Main method
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Dice();

        }
        /// <summary>
        /// Die roll method
        /// </summary>
        public static void Dice()
        {

            int[] tally = new int[11];

            Random rnd = new Random();
            for (int index = 0; index <= 36000; index++)
            {
                int diceOne = rnd.Next(1, 7);
                int diceTwo = rnd.Next(1, 7);
                int sumOfDie = diceOne + diceTwo;

                tally[sumOfDie - 2]++;
            }
            Console.WriteLine(" ===============DICE ROLLER=================");
            Console.WriteLine($"| {"Sum",5} | {"times die are Rolled",-23}|");
            Console.WriteLine(" ===========================================");
            for (int counter = 0; counter < tally.Length; counter++)
            {
                Console.WriteLine($"| {counter + 2,5} | {tally[counter],-23}|");
                Console.WriteLine(" ---------------------------------------");


            }
        }

    }
}