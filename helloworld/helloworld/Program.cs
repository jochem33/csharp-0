using System;

namespace helloworld
{
    class MainClass
    {
        static void Main(string[] args)
        {
            float answer = 0.0f;
            int operatorIndex = -1;
            string operatorStr = "*";


            int firstPartInt = 0;
            int secondPartInt = 0;


            Console.WriteLine("Geef een som: ");
            string input = Console.ReadLine();

            Console.WriteLine(input);

            if (input.Contains("*"))
            {
                operatorIndex = input.IndexOf("*");
                operatorStr = "*";
            }
            else if (input.Contains("/"))
            {
                operatorIndex = input.IndexOf("/");
                operatorStr = "/";
            }
            else if (input.Contains("+"))
            {
                operatorIndex = input.IndexOf("+");
                operatorStr = "+";
            }
            else if (input.Contains("-"))
            {
                operatorIndex = input.IndexOf("-");
                operatorStr = "-";
            }


            if (operatorIndex >= 1)
            {
                string firstPart = input.Substring(0, operatorIndex);
                string secondPart = input.Substring(operatorIndex + 1);

                firstPartInt = Convert.ToInt32(firstPart);
                secondPartInt = Convert.ToInt32(secondPart);

            }

            switch (operatorStr)
            {
                case "*":
                    answer = firstPartInt * secondPartInt;
                    break;
                case "/":
                    if (secondPartInt == 0)
                    {
                        Console.WriteLine("Hee, dat is illegaal!");
                        break;
                    }
                    answer = firstPartInt / secondPartInt;
                    break;
                case "+":
                    answer = firstPartInt + secondPartInt;
                    break;
                case "-":
                    answer = firstPartInt - secondPartInt;
                    break;
            }

            Console.WriteLine(answer);
        }
    }   
}
