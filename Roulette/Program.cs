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

            resultNum += 1;
            Console.WriteLine("\nThe winning bets are as follows below: ");
            //Implementation here
            Console.WriteLine(BetEvenOrOdd(resultNum));
            resultNum -= 1;
            Console.WriteLine(BetRedOrBlack(rouletteArray[resultNum]));
            resultNum += 1;
            Console.WriteLine(BetLowsOrHighs(resultNum));
            Console.WriteLine(BetRowsThirds(resultNum));
        }
        public static string BetRowsThirds(int resultNum)
        {
            string result = "";

            if (resultNum <= 12 && resultNum > 0)
            {
                result = "First Column Wins";
            }
            else if (resultNum >= 13 && resultNum < 25)
            {
                result = "Second Column Wins";
            }
            else if (resultNum >= 25 && resultNum <= 36)
            {
                result = "Third Column Wins";
            }
            else
            {
                result = "No Columns won";
            }
            return result;
        }
        public static string BetLowsOrHighs(int resultNum)
        {
            string result = "";

            if (resultNum >= 19)
            {
                result = "High";
            }
            else if (resultNum > 0 && resultNum < 19)
            {
                result = "Low";
            }

            return result;
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
        public static string BetRedOrBlack(string resultValue) 
        {
            string isRed = "Red";
            string isGreen = "Green";
            string result = "";

            bool red = resultValue.Contains(isRed);
            bool green = resultValue.Contains(isGreen);
            if (red)
            {
                result = "Red";
            }
            else if (green)
            {
                result = "Green";
            }
            else
            {
                result = "Black";
            }
            return result;
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
