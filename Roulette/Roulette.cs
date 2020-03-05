using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette
{
    public class Roulette
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
        public static string BetCorner (int resultNum)
        {
            string result = "";

            //if (resultNum == 1) result = "Winning Corner bet numbers: 1/2/4/5";
            //if (resultNum == 2) result = "Winning Corner bet numbers: 1/2/4/5 or 2/3/5/6";
            //if (resultNum == 3) result = "Winning Corner bet numbers: 2/3/5/6";
            //if (resultNum == 4) result = "Winning Corner bet numbers: 1/2/4/5 or 4/5/7/8";
            //if (resultNum == 5) result = "Winning Corner bet numbers: 1/2/4/5 or 2/3/5/6 or 4/5/7/8 or 5/6/8/9";
            //if (resultNum == 6) result = "Winning Corner bet numbers: 2/3/5/6 or 5/6/8/9";
            //if (resultNum == 7) result = "Winning Corner bet numbers: 4/5/7/8 or 7/8/10/11";
            //if (resultNum == 8) result = "Winning Corner bet numbers:  ";
            //if (resultNum == 9) result = "Winning Corner bet numbers: ";
            //if (resultNum == 10) result = "Winning Corner bet numbers: ";
            //if (resultNum == 11) result = "Winning Corner bet numbers: ";
            //if (resultNum == 12) result = "Winning Corner bet numbers: ";
            //if (resultNum == 13) result = "Winning Corner bet numbers: ";
            //if (resultNum == 14) result = "Winning Corner bet numbers: ";
            //if (resultNum == 15) result = "Winning Corner bet numbers: ";
            //if (resultNum == 16) result = "Winning Corner bet numbers: ";
            //if (resultNum == 17) result = "Winning Corner bet numbers: ";
            //if (resultNum == 18) result = "Winning Corner bet numbers: ";
            //if (resultNum == 19) result = "Winning Corner bet numbers: ";

            int[] verticalColumnOne = new int[] { 4, 7, 10, 13, 16, 19, 22, 25, 28, 31 };
            int[] verticalColumnTwo = new int[] { 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 };
            int[] verticalColumnThree = new int[] { 6, 9, 12, 15, 18, 21, 24, 27, 30, 33 };

            if(resultNum == 1)
            {
                int rightAdjacent = resultNum + 1;
                int below = resultNum + 3;
                int belowRight = resultNum + 4;

                result += "[" + resultNum + "," + rightAdjacent + "," + below + "," + belowRight + "]";
            }
            if(resultNum == 2)
            {
                int leftAdjacent = resultNum - 1;
                int belowLeft = resultNum + 2;
                int below = resultNum + 3;

                int rightAdjacent = resultNum + 1;
                int belowAdjacent = resultNum + 3;
                int belowRight = resultNum + 4;
            }

            if (verticalColumnOne.Contains(resultNum))
            {
                int upperNum = resultNum - 3;
                int rightNum = resultNum + 1;
                int upperRight = upperNum + 1;

                int lowerRight = resultNum + 1;
                int below = resultNum + 3;
                int lowerCornerRight = resultNum + 4;

                result += "["+ upperNum + "," + upperRight +","+ resultNum +"," + rightNum + "]" +
                    "[" + resultNum + "," + lowerRight + "," + below + "," + lowerCornerRight + "]"; ;
            }
            else if (verticalColumnTwo.Contains(resultNum))
            {
                int leftUpperCorner = resultNum - 4;
                int leftUpperRight = leftUpperCorner + 1;
                int leftAdjacent = resultNum - 1;

                int rightUpperCorner = resultNum - 3;
                int rightUpperRight = rightUpperCorner + 1;
                int rightAdjacent = resultNum + 1;

                int leftLowerCorner = resultNum - 1;
                int leftLowerLeft = resultNum + 2;
                int leftCornerBelow = resultNum + 3;

                int rightLowerCorner = resultNum + 1;
                int rightBelow = resultNum + 3;
                int rightLowerRight = resultNum + 4;

                result += "["+ leftUpperCorner +"," + leftUpperRight +","+ leftAdjacent + "," + resultNum + "] "
                  +  "[" + rightUpperCorner + "," + rightUpperRight + "," + rightAdjacent + "," + resultNum + "] " +
                  "[" + leftLowerCorner + "," + resultNum + "," + leftLowerLeft + "," + leftCornerBelow + "] " +
                    "[" + resultNum + "," + rightLowerCorner + "," + rightBelow + "," + rightLowerRight + "] ";
            }
            else if (verticalColumnThree.Contains(resultNum))
            {
                int leftUpperleft = resultNum - 4;
                int leftUpperRight = resultNum - 3;
                int leftAdjacent = resultNum - 1;

                int lowerCornerLeft = resultNum - 1;
                int lowerLeft = resultNum + 2;
                int belowAdjacent = resultNum + 3;

                result += "[" + leftUpperleft + "," + leftUpperRight + "," + leftAdjacent + "," + resultNum + "]" +
                    "[" + lowerCornerLeft + "," + resultNum + "," + lowerLeft + "," + belowAdjacent + "]"; ;
            }
            


            return result;
        }
        public static string BetSixLine(int resultNum)
        {
            string result = "";

            if (resultNum > 0 && resultNum <= 3)
            {
                result = "The 6 line winning numbers are: 1/2/3/4/5/6";
            }
            else if (resultNum >= 4 && resultNum <= 6)
            {
                result = "The 6 line winning numbers are either 1/2/3/4/5/6 or 4/5/6/7/8/9";
            }
            else if (resultNum >= 7 && resultNum <= 9)
            {
                result = "The 6 line winning numbers are either 4/5/6/7/8/9 or 7/8/9/10/11/12";
            }
            else if (resultNum >= 10 && resultNum <= 12)
            {
                result = "The 6 line winning numbers are either 7/8/9/10/11/12 or 10/11/12/13/14/15";
            }
            else if (resultNum >= 13 && resultNum <= 15)
            {
                result = "The 6 line winning numbers are either 10/11/12/13/14/15 or 13/14/15/16/17/18";
            }
            else if (resultNum >= 16 && resultNum <= 18)
            {
                result = "The 6 line winning numbers are either 13/14/15/16/17/18 or 16/17/18/19/20/21";
            }
            else if (resultNum >= 19 && resultNum <= 21)
            {
                result = "The 6 line winning numbers are either 16/17/18/19/20/21 or 19/20/21/22/23/24";
            }
            else if (resultNum >= 22 && resultNum <= 24)
            {
                result = "The 6 line winning numbers are either 19/20/21/22/23/24 or 22/23/24/25/26/27";
            }
            else if (resultNum >= 25 && resultNum <= 27)
            {
                result = "The 6 line winning numbers are either 22/23/24/25/26/27 or 25/26/27/28/29/30";
            }
            else if (resultNum >= 28 && resultNum <= 30)
            {
                result = "The 6 line winning numbers are either 25/26/27/28/29/30 or 28/29/30/31/32/33";
            }
            else if (resultNum >= 31 && resultNum <= 33)
            {
                result = "The 6 line winning numbers are either 28/29/30/31/32/33 or 31/32/33/34/35/36";
            }
            else if (resultNum >= 34 && resultNum <= 36)
            {
                result = "The 6 line winning numbers are 31/32/33/34/35/36";
            }
            else
            {
                result = "No winning six lines.";
            }
            return result;
        }
        public static string BetSplit(int currentNum)
        {
            string result = "";
            if (currentNum == 37 || currentNum == 38)
            {
                result = "No Split Bet wins.";
            }
            if (currentNum == 1)
            {
                int rightAdjacency = currentNum + 1;
                int downAdjacency = currentNum + 3;

                result += "[" + currentNum + "," + rightAdjacency.ToString() + "] " + "[" + currentNum + "," + downAdjacency + "]";
            }
            else if (currentNum == 2)
            {
                int downAdjacency = currentNum + 3;
                int leftAdjacency = currentNum - 1;
                int rightAdjacency = currentNum + 1;
                result += "[" + currentNum + "," + rightAdjacency + "] " + "[" + currentNum + "," + downAdjacency + "] "
                    + "[" + currentNum + "," + leftAdjacency + "]";
            }
            else if (currentNum == 3)
            {
                int downAdjacency = currentNum + 3;
                int leftAdjacency = currentNum - 1;
                result += "[" + currentNum + "," + downAdjacency + "] "
                   + "[" + currentNum + "," + leftAdjacency + "]";
            }
            else if (currentNum == 34)
            {
                int upAdjacency = currentNum - 3;
                int rightAdjacency = currentNum + 1;
                result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                    + rightAdjacency + "] ";
            }
            else if (currentNum == 35)
            {
                int leftAdjacency = currentNum - 1;
                int upAdjacency = currentNum - 3;
                int rightAdjacency = currentNum + 1;
                result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
             + rightAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";

            }
            else if (currentNum == 36)
            {
                int leftAdjacency = currentNum - 1;
                int upAdjacency = currentNum - 3;
                result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";
            }
            else if (currentNum == 4 || currentNum == 7 || currentNum == 10 || currentNum == 13 || currentNum == 16 || currentNum == 19 ||
                     currentNum == 22 || currentNum == 25 || currentNum == 28 || currentNum == 31)
            {
                int upAdjacency = currentNum - 3;
                int downAdjacency = currentNum + 3;
                int rightAdjacency = currentNum + 1;
                result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                    + rightAdjacency + "] " + "[" + currentNum + "," + downAdjacency + "]";
            }
            else if (currentNum == 5 || currentNum == 8 || currentNum == 11 || currentNum == 14 || currentNum == 17 ||
                     currentNum == 20 || currentNum == 23 || currentNum == 26 || currentNum == 29 || currentNum == 32)
            {
                int upAdjacency = currentNum - 3;
                int downAdjacency = currentNum + 3;
                int leftAdjacency = currentNum - 1;
                int rightAdjacency = currentNum + 1;
                result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                    + rightAdjacency + "] " + "[" + currentNum + "," + downAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";
            }
            else if (currentNum == 6 || currentNum == 9 || currentNum == 12 || currentNum == 15 || currentNum == 18 ||
                     currentNum == 21 || currentNum == 24 || currentNum == 27 || currentNum == 30 || currentNum == 33)
            {
                int upAdjacency = currentNum - 3;
                int downAdjacency = currentNum + 3;
                int leftAdjacency = currentNum - 1;
                result += "[" + currentNum + "," + upAdjacency + "] "
                    + "[" + currentNum + "," + downAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";
            }
            return result;
        }
        public static string BetStreet(string[] stringArray, int currentIndex)
        {
            string result = "";
            string plusOne = "";
            string minusOne = "";

            if (currentIndex >= 2 && currentIndex <= 35)
            {
                plusOne = stringArray[currentIndex + 1];
                minusOne = stringArray[currentIndex - 1];
                result = "Street rows winners: " + minusOne + " | " + stringArray[currentIndex] + " | " + plusOne;
            }
            else
            {
                result = "No street row winners";
            }
            return result;
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

            if (resultNum >= 19 && resultNum < 36)
            {
                result = "High";
            }
            else if (resultNum > 0 && resultNum < 19)
            {
                result = "Low";
            }
            else
            {
                result = "The ball landed on a green bin, no low or high bet winners.";
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
            else if (resultNum != 0)
            {
                resultString += "Odds";
            }
            return resultString;

        }

    }
}
