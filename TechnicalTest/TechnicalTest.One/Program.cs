using System;
using static TechnicalTest.Library.Helpers;

namespace TechnicalTest.One
{
    /*
        Write a program that prints the numbers from 1 to 100.
        Write your code in the FizzBuzz.Run() static Method.
        For numbers divisible by 3, print “Fizz”.
        For numbers divisible by 5, print “Buzz”.
        For numbers divisible by both 3 and 5, print “FizzBuzz”.
        For all other numbers display the number itself.
        Have each phrase start on its own line using '\n'.
        Do not alter Main();
    */

    public class TestOne
    {
        static void Main()
        {
            // Do Not Alter This Code
            switch (FizzBuzz.Run() == TestOneExpectedResult)
            {
                case true:
                    Pass();
                    break;
                case false:
                    Fail();
                    break;
            }
        }

        public static class FizzBuzz
        {
            // Write your Code In This Method
            public static string Run() {
                string result = "";
                for (int i = 1; i < 101; i++)
                {
                    if (i % 5 == 0)
                    {
                        if (i % 3 == 0)
                        {
                            result += "FizzBuzz";
                        }
                        else
                        {
                            result += "Buzz";
                        }
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            result += "Fizz";
                        }
                        else
                        {
                            result += $"{i}";
                        }
                    }
                    if (i < 100) result += "\n";
                }
                return result;
            }
        }
    }
}
