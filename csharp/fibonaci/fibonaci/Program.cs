using System;

namespace fibonaci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 2;

            int[] numbers = new int[20];

            for (int i = 1; i < 20; i++)
            {
                int thirdNumber = firstNumber + secondNumber;

                firstNumber = secondNumber;
                secondNumber = thirdNumber;

                Console.WriteLine(secondNumber);
                numbers[i] = secondNumber;
            }
        }
    }
}
