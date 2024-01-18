using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Final
{
    class RollDice
    {
        //Create the RollDicemethod that receives HowManyRolls as a parameter
        public static int[] RollDiceMethod(int HowManyRolls)
        {
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            Random random = new Random();
            int[] rollTotals = new int[13];

            //For every time the user said to roll the dice, roll them and store the count of each total in the rollTotals array
            for (int iCount = 0; iCount < HowManyRolls; iCount++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                rollTotals[total - 2]++;
            }

            //This is what the method is returning, this array
            return rollTotals;

        }
    }
}
