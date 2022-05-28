using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Declarations_and_Expressions
{
    static class Exercises
    {
        //1. Write a C# Sharp program to print Hello and your name in a separate line.
        public static void PrintHelloAndName()
        {
            Console.Write("What is your name? ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            string name = Console.ReadLine();
            Console.Write("Hello, " + name + "!");
            Console.ResetColor();
        }

        //2. Write a C# Sharp program to print the sum of two numbers.
        public static void PrintSumOf2Numbers()
        {
            int num1, num2, sum;
            string yesNo;

            void Input()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("First number : ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Second number : ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Are you allowed to use negative(-) number? Y/N ");
            yesNo = Console.ReadLine();

            if (yesNo == "Y"|| yesNo == "y")
            {
                Input();
                sum = num1 + num2;
                Console.WriteLine("Sum of the 2 numbers : " + sum);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            else if (yesNo == "N" || yesNo == "n")
            {
                Console.Write("Write only positive numbers! \nPress Enter key");
                Console.ReadLine();
                Input();
                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("You are not allowed to write any negative(-) number!");
                    Input();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Input();
            }

            Console.ResetColor();

            PrintSumOf2Numbers();
        }

        //3. Write a C# Sharp program to print the result of dividing two numbers.
        public static double Divide2Numbers()
        {
            double dividend, divisor, result;
            Console.Write("Dividend : ");
            dividend = Convert.ToDouble(Console.ReadLine());
            Console.Write("Divisor : ");
            divisor = Convert.ToDouble(Console.ReadLine());

            result = dividend / divisor;

            Console.Write("Division of 2 numbers : " + result);
            Console.ReadLine();

            Divide2Numbers();

            return 0.0;
        }

        //4. Write a C# Sharp program to print the result of the specified operations.
        public static void PrintResultOfSpecifiedOperations()
        {
            /*
             Test data:
                -1 + 4 * 6
                ( 35+ 5 ) % 7
                14 + -4 * 6 / 11
                2 + 15 / 6 * 1 - 7 % 2
             */

            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            void PrintResultOfSpecifiedOperations1()
            {
                int num1, num2, num3, num4, num5, result;
                string plus = " + ";
                string minus = " - ";
                string multiplication = " * ";
                string division = " / ";

                Console.Write("Number 1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Operator : ");
                plus = Convert.ToString(Console.ReadLine());

                Console.Write("Numer 2 : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Operator : ");
                minus = Convert.ToString(Console.ReadLine());

                Console.Write("Number 3 : ");
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Operator : ");
                multiplication = Convert.ToString(Console.ReadLine());

                Console.Write("Number 4 : ");
                num4 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Operator : ");
                division = Convert.ToString(Console.ReadLine());

                Console.Write("Number 5 : ");
                num5 = Convert.ToInt32(Console.ReadLine());
            }
        }

        //5. Write a C# Sharp program to swap two numbers.
        public static void SwapTwoNumbers()
        {
            /*
             Test Data:
                Input the First Number : 5
                Input the Second Number : 6
                    Expected Output:
                        After Swapping :
                        First Number : 6
                        Second Number : 5
             */

            Console.Write("Input the First Number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\tExpected Output: ");
            
            Console.WriteLine("\t\tAfter Swapping : ");
            Console.WriteLine("\t\t\tFirst Number : " + SecondNumber);
            Console.WriteLine("\t\t\tSecond Numer : " + FirstNumber);
        }

        //6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
        public static void PrintOutputOfMultiplicationOf3Numbers()
        {
            /*Test Data:
                Input the first number to multiply: 2
                Input the second number to multiply: 3
                Input the third number to multiply: 6
                    Expected Output:
                        2 x 3 x 6 = 36
            */
            Console.Write("Input the first number to multiply : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply : ");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());

            int result = FirstNumber * SecondNumber * ThirdNumber;

            //Console.WriteLine("\t\t" + FirstNumber + " x " + SecondNumber + " x " + ThirdNumber + " = " + result);

            Console.WriteLine("\tExpected Output : ");
            Console.WriteLine("\t\t{0} x {1} x {2} = {3}", FirstNumber, SecondNumber, ThirdNumber, result);
        }

        //7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered
        //by the user.
        public static void PrintOutputAddSubMultDivOf2Numbers()
        {
            /*Test Data:
                Input the first number: 25
                Input the second number: 4
                Expected Output:
                25 + 4 = 29
                25 - 4 = 21
                25 x 4 = 100
                25 / 4 = 6
                25 mod 4 = 1
            */
            Console.Write("Input the first number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            /*
                Console.WriteLine("Output : ");
                Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + FirstNumber + SecondNumber);
                Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " + FirstNumber +- SecondNumber);
                //Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " + FirstNumber - SecondNumber);
                Console.WriteLine(FirstNumber + " x " + SecondNumber + " = " + FirstNumber * SecondNumber);
                Console.WriteLine(FirstNumber + " / " + SecondNumber + " = " + FirstNumber / SecondNumber);
                Console.WriteLine(FirstNumber + " mod " + SecondNumber + " = " + FirstNumber % SecondNumber);
            */
            Console.WriteLine("Output : ");
            Console.WriteLine("{0} + {1} = {2}", FirstNumber, SecondNumber, FirstNumber+SecondNumber);
            Console.WriteLine("{0} - {1} = {2}", FirstNumber, SecondNumber, FirstNumber - SecondNumber);
            Console.WriteLine("{0} * {1} = {2}", FirstNumber, SecondNumber, FirstNumber * SecondNumber);
            Console.WriteLine("{0} / {1} = {2}", FirstNumber, SecondNumber, FirstNumber / SecondNumber);
            Console.WriteLine("{0} mod {1} = {2}", FirstNumber, SecondNumber, FirstNumber % SecondNumber);
        }

        //8. Write a C# Sharp program that takes a number as input and print its multiplication table.
        public static void PrintMultiplicationTableOfAnyNumber()
        {
            /*Test Data:
                Enter the number: 5
                Expected Output:
                5 * 0 = 0
                5 * 1 = 5
                5 * 2 = 10
                5 * 3 = 15
                ....
                5 * 10 = 50
            */
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output :");
            for (int x=0; x <= 10; x++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, x, number * x);
            }

        }

        //9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
        public static void CalculateAndPrintAverageOf4Numbers()
        {
            /*
            Test Data:
                Enter the First number: 10
                Enter the Second number: 15
                Enter the third number: 20
                Enter the four number: 30

                Expected Output:
                The average of 10 , 15 , 20 , 30 is: 18
            */

            Console.Write("Enter the First number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number : ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth number : ");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            int average = (firstNumber + secondNumber + thirdNumber + fourthNumber)/4;

            Console.WriteLine();
            Console.WriteLine("Output : ");
            Console.WriteLine("{0}, {1}, {2}, {3} is: {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, average);
            Console.ReadLine();
        }

        //10. Write a C# Sharp program that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
        public static void PrintOutputOf3NumbersInDifferentCalculations()
        {
            /*
            Test Data:
                Enter first number - 5
                Enter second number - 6
                Enter third number - 7

                Expected Output:
                Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
            */
            Console.Write("Enter first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int result1 = (firstNumber + secondNumber) * thirdNumber;
            int result2 = firstNumber * secondNumber + secondNumber * thirdNumber;

            Console.WriteLine();
            Console.WriteLine("Output");
            Console.Write("Result of specified numbers {0}, {1} and {2}, ({0}+{1}).{2} is {3} and {0}.{1} + {1}.{2} is {4}", 
                firstNumber, secondNumber, thirdNumber, result1, result2);
            Console.ReadLine();
        }

        //11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
        public static void TakeAgeAndPrintSomething()
        {
            /*
            Test Data:
                Enter your age - 25
                Expected Output:
                You look older than 25
            */
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Output : ");
            Console.WriteLine("You look older than {0}", age);
        }

        //12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next
        //row, with no separation. You should do it two times: Use Console. Write and then use {0}.
        public static void DisplayTakenNumber4TimesInSingleRow()
        {
            /*
            Test Data:
                Enter a digit: 25
                Expected Output:
                25 25 25 25
                25252525
                25 25 25 25
                25252525
            */

            Console.Write("Enter a digit : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Output : ");

            for(int i=0; i<=1; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
                for(int k=3; k>=0; k--)
                {
                    Console.Write("{0}", number);
                }
                Console.WriteLine();
            }

        }

        //13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
        
        public static void CreateRectangleUsingInputNumber()
        {
            /*
            Test Data:
                Enter a number: 5
                Expected Output:
                555
                5 5
                5 5
                5 5
                555
            */
            Console.Write("Enter a number : ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<=4; i++)
            {
                Console.Write("{0}", inputNumber);
                for (int j=0; j<=1; j++)
                {
                    Console.Write("{0}", inputNumber);
                }
                Console.WriteLine();

                for (i = 1; i <= 2; i++)
                {
                    Console.Write("{0}", inputNumber);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
