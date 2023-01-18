using System;

namespace Mission_2_Brandon_Griffiths
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceGenerator dg = new DiceGenerator();

            Console.WriteLine("Welcome to the dice throwing simulator!\n");

            Console.WriteLine("How many dice rolls would you like to simulate?\n");

            int diceRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS:");

            dg.DiceCount(diceRolls);


            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");



        }
    }
}
