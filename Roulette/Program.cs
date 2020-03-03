using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("The number that the ball landed on is" + RandomizeRoulette());


        }
        public static int RandomizeRoulette()
        {
            string[] rouletteArray = new string[] { "00", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", 
                                                    "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24",
                                                    "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };
            Random random = new Random();
            for (int i = 0; i < rouletteArray.Length -1 ; i++)
            {
                int j = random.Next(i, rouletteArray.Length);

            }

            return 1;
        }
    }

    class Roulette
    {
        //To do
        //Win cases: 
        //Numbers: the number of the bin
        //Evens or Odds: even or odd numbers
        //Reds or Blacks: red or black colored numbers
        //Lows or Highs: 1-18 (low) or 19-38 (high)
        //Dozens: row thirds, 1-12, 13-24, 25-36
        //Columns: first, second, or third columns
        //street: rows, 1/2/3 or 22/23/24
        //6 Numbers: double rows , 1/2/3/4/5/6 or 22/23/24/25/26
        //Split: at the edge of any two contiguous numbers 1/2 , 11/14,  and 35/36
        //Corner: at the intersection of any four contiuous numbers , 1/2/4/5 , or 23/24/26/27


    }
}
