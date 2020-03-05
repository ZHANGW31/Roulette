using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {   
            //In this array, index 36 and 37 represents 0 and 00 respectively.
            string[] rouletteArray = new string[] { "Red : 1", "Black : 2", "Red : 3", "Black : 4", "Red : 5",
                                                    "Black : 6", "Red : 7", "Black : 8", "Red : 9", "Black : 10", "Black : 11", "Red : 12",
                                                    "Black : 13", "Red : 14", "Black : 15", "Red : 16", "Black : 17", "Red : 18", "Red : 19",
                                                    "Black : 20", "Red : 21", "Black : 22", "Red : 23", "Black : 24", "Red : 25", "Black : 26",
                                                    "Red : 27", "Black : 28", "Black : 29", "Red : 30", "Black : 31", "Red : 32", "Black : 33",
                                                    "Red : 34", "Black : 35", "Red : 36", "Green : 0", "Green : 00" };
            int resultNum = Roulette.RandomizeRoulette(rouletteArray) - 1;
            int indexNum = resultNum;
            Console.WriteLine("The bin that the ball landed on is " + rouletteArray[resultNum]);
            resultNum += 1;
            Console.WriteLine("\nThe winning bets are as follows below: ");
            //Implementation here
            Console.WriteLine(Roulette.BetEvenOrOdd(resultNum));           
            Console.WriteLine(Roulette.BetRedOrBlack(rouletteArray[indexNum]));
            Console.WriteLine(Roulette.BetLowsOrHighs(resultNum));
            Console.WriteLine(Roulette.BetRowsThirds(resultNum));
            Console.WriteLine(Roulette.BetStreet(rouletteArray, indexNum));           
            Console.WriteLine("Split win cases: " + Roulette.BetSplit(resultNum));
            Console.WriteLine(Roulette.BetSixLine(resultNum));
        }

    }
}
