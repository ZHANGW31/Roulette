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


            int resultNum = RandomizeRoulette(rouletteArray) - 1;
            Console.WriteLine("The bin that the ball landed on is " + rouletteArray[resultNum]);
            Console.WriteLine("The result num currently is " + resultNum);
            resultNum += 1;
            Console.WriteLine("\nThe winning bets are as follows below: ");
            //Implementation here
            Console.WriteLine(BetEvenOrOdd(resultNum));
        }
        public static int RandomizeRoulette(string[] rouletteArray)
        {
            Random random = new Random();
            int resultIndex = random.Next(rouletteArray.Length - 1);
            int realNumber = resultIndex + 1;
            Console.WriteLine("Spinning...");
            Console.WriteLine(realNumber);
            return realNumber;
        }
        public static string BetEvenOrOdd(int resultNum)
        {
            string resultString = "";

            if (resultNum > 36)
            {
                resultString += "It is neither even or odd.";
            }
            resultNum %= 2;
            if (resultNum == 0)
            {
                resultString += "Evens";
            }
            else
            {
                resultString += "Odds";
            }

            return resultString;

        }
    }

    class Roulette
    {
        //To do
        //Win cases: 
        //Numbers: the number of the bin
        //Evens or Odds: even or odd numbers
        //Reds or Blacks: red or black colored numbers
        //Lows or Highs: 1:18 (low) or 19:38 (high)
        //Dozens: row thirds, 1:12, 13:24, 25:36
        //Columns: first, second, or third columns
        //street: rows, 1/2/3 or 22/23/24
        //6 Numbers: double rows , 1/2/3/4/5/6 or 22/23/24/25/26
        //Split: at the edge of any two contiguous numbers 1/2 , 11/14,  and 35/36
        //Corner: at the intersection of any four contiuous numbers , 1/2/4/5 , or 23/24/26/27


    }
}
