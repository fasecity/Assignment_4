using System;
using System.Collections.Generic;
/// <summary>
/// Name: Mohamoud Mohamed
/// student#:300435435
/// Assigment 4 part B
/// version 1.1
/// </summary>
namespace Assignment_4
{
    class Program
    {   /// <summary>
    /// Main method
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {

            List<string> seating = new List<string>();
            for (int index = 0; index < 10; index++)
            {
                seating.Add(index <= 4 ? "Economy" : "First Class");
            }
            List<string> assignedSeat = new List<string>();

            DisplayMenu(seating, assignedSeat);

        }
        /// <summary>
        /// this method shows menu
        /// </summary>
        /// <param name="seating"></param>
        /// <param name="assignedSeat"></param>
        public static void DisplayMenu(List<string> seating, List<string> assignedSeat)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. First Class");

                Console.WriteLine("2. Economy");

                Console.WriteLine("3. Exit");

                Console.WriteLine("Please Select Your option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        FirstClass(seating, assignedSeat);
                        break;
                    case 2:
                        Economy(seating, assignedSeat);
                        break;
                    case 3:
                        loop = false;
                        break;


                }

            }
        }

        /// <summary>
        /// This method adds customer to first Class
        /// </summary>
        /// <param name="seats"></param>
        /// <param name="assigned"></param>
        public static void FirstClass(List<string> seats, List<string> assigned)
        {
            if (!seats.Remove("First Class"))
            {
                Console.WriteLine("Is it alright to be in the economy section?");
                string answer = Console.ReadLine();

                if (answer != "yes")
                    Console.WriteLine("Sorry your next flight leaves in a few hours");
                else
                    Economy(seats, assigned);
            }
            else
            {
                assigned.Add("First Class");
                Console.WriteLine("You have been added to first class");
            }
        }

        /// <summary>
        /// This method adds the customer to economy
        /// </summary>
        /// <param name="seat"></param>
        /// <param name="assigned"></param>
        public static void Economy(List<string> seat, List<string> assigned)
        {
            if (seat.Remove("Economy"))
            {
                assigned.Add("Economy");
                Console.WriteLine("You have been added to economy class");
            }
            else
            {
                Console.WriteLine("Is it okay to be placed in the First Class section");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    FirstClass(seat, assigned);
                }
                else
                {
                    Console.WriteLine("Sorry but your next flight will leave in a few hours");
                }
            }
        }
    }
}
