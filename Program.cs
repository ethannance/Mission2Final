//Ethan Nance program that rolls dice

namespace Mission2Final
{
    class Other
    {
        //Create main class
        public static void Main(string[] args)
        {
            //Welcomes and gathers input from user
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            int HowManyRolls = int.Parse(Console.ReadLine()); //Takes input from keyboard above
            int[] rollTotalsReceived = RollDice.RollDiceMethod(HowManyRolls); //This passes HowManyrolls into the RollDiceMethod, and stores the value that the method is returning (rollTotals) into a new varaible called rollTotalsReceived

            //Write other stuff
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {HowManyRolls}.");

            //Get percentage of how many times each total happened by accessing positions in array
            for (int iCount2 = 0; iCount2 < 11; iCount2++)
            {
                int percentage = (int)((double)rollTotalsReceived[iCount2] / HowManyRolls * 100);
                Console.Write((iCount2 + 2) + ": ");

                //Print the same number of * as there was percentage ints in each position of array
                for (int iCount3 = 0; iCount3 < percentage; iCount3++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); //Moves to new line
            }
            //bye bye
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}




