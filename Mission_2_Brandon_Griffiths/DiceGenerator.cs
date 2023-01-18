using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Brandon_Griffiths
{
    class DiceGenerator
    {
        public void DiceCount (int diceRolls)
        {
            Random rnd = new Random();   
            
            int[] rolls;

            rolls = new int[11];

            // gets the random numbers
            for (int j = 0; j < diceRolls; j++)
            {
                int ranNum = 0;
                int ranNum2 = 0;
                int total = 0;

                ranNum = rnd.Next(6) + 1;
                ranNum2 = rnd.Next(6) + 1;
                total = ranNum + ranNum2;


                // adding 1 to elements of the array
                if (rolls[total - 2] >= 1)
                {
                    rolls[total - 2]++;
                }
                else
                {
                    rolls[total - 2] = 1;
                }

            }

            string[] stars = new string[11];

            // creating the *'s
            for (int i = 0; i < rolls.Length; i++)
            {
                int number = 0;

                int num = 0;

                number = (i + 2);

                num = rolls[i];

                rolls[i] = (int)Math.Round(((double)num / diceRolls) * 100);

                // adding the number of stars to the string
                for (int n = 0; n < rolls[i]; n++)
                {
                    stars[i] += '*';
                }


                Console.WriteLine(number + ": " + stars[i]);
            }

        }
    }
}
