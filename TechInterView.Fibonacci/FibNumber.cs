using System;
using System.Collections.Generic;
namespace TechInterView.Fibonacci;

public class FibNumber
{
    private static int firstNumber = 0, secondNumber = 1;

    public static int GetFib(int position)
    {
        if (position > 1)
        {
            for (int i = 1; i < position; i++)
            {
                //current sum
                var fibonacciNumber = secondNumber + firstNumber; 

                firstNumber = secondNumber;


                //second number variable becomes the fibonacci number
                secondNumber = fibonacciNumber;
            }

            //basic substitution to maintain same variable and accomodatin for when position is either 1 or 2
            position = secondNumber;
        }

        return position;
    }
}
