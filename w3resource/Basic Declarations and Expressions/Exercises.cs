<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            Console.WriteLine("{0}{0}{0}", inputNumber);
            Console.WriteLine("{0} {0}", inputNumber);
            Console.WriteLine("{0} {0}", inputNumber);
            Console.WriteLine("{0} {0}", inputNumber);
            Console.WriteLine("{0}{0}{0}", inputNumber);

            //for(int i=0; i<=4; i++)
            //{
            //    Console.Write("{0}", inputNumber);
            //    for (int j=0; j<=1; j++)
            //    {
            //        Console.Write("{0}", inputNumber);
            //    }
            //    Console.WriteLine();

            //    for (i = 1; i <= 2; i++)
            //    {
            //        Console.Write("{0}", inputNumber);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
        }

        //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
        public static void ConvertFromCelciusToKelvinAndFarenheit()
        {
            /*Test Data:
                Enter the amount of celsius: 30
                Expected Output:
                Kelvin = 303
                Fahrenheit = 86*/
            Console.Write("Celcius : ");
            decimal celcius = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("kelvin =  {0}", celcius + 273);
            //Console.ReadLine();

            Console.WriteLine("farenheit = {0}", celcius * 18 / 10 + 32);
            //Console.ReadLine();
        }

        //15. Write a C# program to remove a specified character from a non-empty string using index of a character.
        public static void RemoveSpecifiedCharacterFromNonEmptyStringUsingIndexOfACharacter()
        {        /*
          * Test Data:
            w3resource
            Sample Output:
            wresource
            w3resourc
            3resource
        */
            Console.WriteLine("Write your string : ");
            string yourString = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Write the index you want to remove your string from : ");
            int yourIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(RemoveSpecifiedCharacter(yourString, yourIndex));
            Console.WriteLine();
            Console.WriteLine(RemoveSpecifiedCharacter("Reaz U Ahmed", 8));
            Console.WriteLine(RemoveSpecifiedCharacter("Reaz U Ahmed", 17));

            static string RemoveSpecifiedCharacter(string specifiedCharacter, int num1)
            {
                if(num1 !< specifiedCharacter.Length)
                {
                    return specifiedCharacter.Remove(num1);
                }
                else
                {
                    return "The index you specified is beyond the limit of your string!";
                }
            }
            RemoveSpecifiedCharacterFromNonEmptyStringUsingIndexOfACharacter();
        }

        //16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        public static void CreateNewStringFromGivenStringWhereFirstAndLastCharChangePosition()
        {
            /*
             Test Data:
                w3resource
                Python
                Sample Output:
                e3resourcw
                nythoP
                x
             */
            Console.Write("Give your string : ");
            string givenString = Console.ReadLine();

            Console.WriteLine(First_Last(givenString));

            static string First_Last(string ustr)
            {
                return ustr.Length > 1
                    ? ustr.Substring(ustr.Length - 1) +
                    ustr.Substring(1, ustr.Length - 2) +
                    ustr.Substring(0, 1) : ustr;
            }
            CreateNewStringFromGivenStringWhereFirstAndLastCharChangePosition();
        }

        //17. Write a C# program to create a new string from a given string (length 1 or more) with the first character added at the front and back.
        //i.e. Reaz will become RReaz and ReazR
        public static void CreateNewStringFromGivenStringWithFirstCharAddedAtFrontAndBack()
        {
            /*
             Sample Output:
                Input a string : The quick brown fox jumps over the lazy dog.
                TThe quick brown fox jumps over the lazy dog.T
             */
            Console.Write("Given String : ");
            string ustr = Console.ReadLine();

            if (ustr.Length >= 1)
            {
                var s = ustr.Substring(0, 1);
                Console.WriteLine(s + ustr + s);
            }

        }

        //18. Write a C# program to check two given integers and return true if one is negative and one is positive.
        public static void Check2GivenIntersAndReturnTruIfOneIsNegativeAndOneIsPositive()
        {
            /*
             Sample Output:
                Input first integer:
                -5
                Input second integer:
                25
                Check if one is negative and one is positive:
                True
             */
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            if (firstInteger < 1)
            {
                Console.WriteLine("True");
            }
            else if (secondInteger < 1)
            {
                Console.WriteLine("False");
            }
            else if (firstInteger == 1111 || secondInteger == 9999)
            {
                Environment.Exit(0);
                //Application.Exit();
            }
            else
            {
                Console.WriteLine("Not a vlaid input...");
            }
            Check2GivenIntersAndReturnTruIfOneIsNegativeAndOneIsPositive();
        }

        //19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
        public static void ComputeSumOf2GivenIntegersIf2ValuesAreEqualReturnTripleOfTheirSum()
        {
            Console.WriteLine("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            int sum = firstInteger + secondInteger;
            Console.WriteLine("Sum of 2 integers : " + sum);

            if(firstInteger == secondInteger)
            {
                Console.WriteLine("Triple of two given integers : " + sum * 3);
            }
        }

        //20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the
        //absolute value of the difference if the first number is greater than second number
        public static void GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum()
        {
            Console.Write("First number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int absoluteValue = firstNumber - secondNumber;

            if(absoluteValue < 0)
            {
                absoluteValue = -absoluteValue;
                Console.Write("Absolute value : " + absoluteValue);
            }
            Console.WriteLine();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Double the absolute value : " + absoluteValue);
            }
            Console.WriteLine();
            GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum();
        }

        //20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the
        //absolute value of the difference if the first number is greater than second number
        public static void GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum_1()
        {
            Console.Write("First number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result(firstNumber, secondNumber));

            static int result(int num1, int num2)
            {
                if (num1 > num2)
                {
                    Console.Write("Double the absolute value of difference between first and second numbers : ");
                    return (num1 - num2) * 2;
                }
                Console.Write("Absolute value of difference between first and second numbers : ");
                return num2 - num1;
            }
            GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum_1();
        }

        //21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
        public static void CheckSumOfTwoGivenIntegersAndReturnTrueIfOneIntegerIs20OrTheirSumIs20()
        {
            Console.Write("First integer : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum=num1+num2;

            sum = num1 + num2;
            if (num1 == 20 || num2 == 20 || sum == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            CheckSumOfTwoGivenIntegersAndReturnTrueIfOneIntegerIs20OrTheirSumIs20();
        }

        //22. Write a C# program to check if a given integer is within 20 of 100 or 200.
        public static void CheckIfGivenIntegerIsWithin20Of100Or200()
        {
            /*
             Sample Output:
                Input an integer:
                25
                False
             */
            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));

            static bool result(int n)
            {
                if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                    return true;
                return false;
            }
            CheckIfGivenIntegerIsWithin20Of100Or200();
        }

        //23. Write a C# program to convert a given string into lowercase.
        public static void ConvertGivenStringIntoLowerCase()
        {
            Console.Write("Input the string : ");
            string givenString = Console.ReadLine();

            Console.WriteLine(ConvertIntoLowerCase(givenString));

            static string ConvertIntoLowerCase(string s)
            {
                return s.ToLower();
            }
            ConvertGivenStringIntoLowerCase();
        }

        //24. Write a C# program to find the longest word in a string.
        public static void FindLongestWordInString()
        {
            Console.Write("Write a string that contains a group of words : ");
            string line = Console.ReadLine();

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            
            foreach(string s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }

        //25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
        public static void PrintOddNumbersFrom1to99()
        {
            /*
             Sample Output:
                Odd numbers from 1 to 99. Prints one number per line.
                1
                3
                5
                7
                9
                ...
                95
                97
                99
             */
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int x = 1; x<(num+1); x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x.ToString());
                }
            }
            PrintOddNumbersFrom1to99();
        }

        //26. Write a C# program to compute the sum of the first 500 prime numbers.
        public static void ComputeSumOfFirst500PrimeNumbers()
        {
            /*
             Sample Output:
                Sum of the first 500 prime numbers:
                824693
             */

            Console.Write("Enter the number you wanted to get the sum of the first 500 prime numbers : ");
            long number = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Sum of the first 500 prime numbers : ");
            long sum = 0;
            int ctr = 0;
            int n = 2;

            //while (ctr < 500)
            while (ctr < number)
            {
                if (IsPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum.ToString());
            
            static bool IsPrime(int n)
            {
                int x = (int)Math.Floor(Math.Sqrt(n));

                if (x == 1) return false;
                if (x == 2) return true;

                for(int i=2; i<=x; ++i)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }

        //27. Write a C# program and compute the sum of the digits of an integer.
        public static void ComputeSumOfDigitsOfAnInteger()
        {
            Console.Write("Input an integer : ");
            int input = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }
            Console.WriteLine("Sum of the digits of said integer : " + sum);

            ComputeSumOfDigitsOfAnInteger();
        }

        //28. Write a C# program to reverse the words of a sentence
        public static void ReverseTheWordsOfASentence()
        {
            /*
             Sample Output:
                Original String: Display the pattern like pyramid using the alphabet.
                Reverse String: alphabet. the using pyramid like pattern the Display
             */
            Console.Write("Original String : ");
            string sentence = Console.ReadLine();
            //Console.WriteLine("Original String : " + sentence);

            string result = "";

            List<string> wordList = new List<string>();
            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);

            for(int i = words.Length-1; i>=0; i--)
            {
                result += words[i] + " ";
            }
            wordList.Add(result);

            foreach(string s in wordList)
            {
                Console.WriteLine("Reverse String : " + s);
            }
        }

        //29. Write a C# program to find the size of a specified file in bytes.
        public static void FindSizeOfFileInBytes()
        {
            /*
             Sample Output:
                Size of a file: 31
             */
            FileInfo fileInfo = new FileInfo("D:/w3resource/Basic Declarations and Expressions/Help/NumberPatterns.cs");
            Console.WriteLine("\nSize of file: " + fileInfo.Length.ToString()+ " bytes");
        }

        //30. Write a C# program to convert a hexadecimal number to decimal number.
        public static void ConvertHexaDecimalNumberToDecimalNumber()
        {
            /*
             Sample Output:
                Hexadecimal number: 4B0
                Convert to-
                Decimal number: 1200
             */
            try
            {
                Console.Write("Hexadecimal number: ");
                String hexadecimal = Convert.ToString(Console.ReadLine());
                int decimalValue = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber);

                Console.Write("Convert to-");
                Console.WriteLine("Decimal number : " + decimalValue);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

            ConvertHexaDecimalNumberToDecimalNumber();
        }

        //31. Write a C# program to multiply corresponding elements of two arrays of integers.
        public static void MultiplyCorrespondingElementsOfTwoArraysOfIntegers()
        {
            /*
             Sample Output:
                Array1: [1, 3, -5, 4]
                Array2: [1, 4, -5, -2]
                Multiply corresponding elements of two arrays:
                1 12 25 -8
             */

            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(" ", first_array));
            Console.WriteLine("\nArray2: [{0}]", string.Join(" ", second_array));

            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            for(int i=0; i<first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        //32. Write a C# program to create a new string of four copies, taking last four characters from a given string.
        //If the length of the given string is less than 4 return the original one.
        public static void CreateNewStringOf4CopiesWithLast4CharactersFromAGivenString()
        {
            /*
             Sample Output:
                Input a string : The quick brown fox jumps over the lazy dog.
                dog.dog.dog.dog.
             */
            Console.Write("Write your string: ");
            //The quick brown fox jumps over the lazy dog.
            string myString = Console.ReadLine();

            if (myString.Length > 4)
            {
                //Console.WriteLine(myString.Length<4? myString + myString + myString:myString.Substring(myString.Length-4)+myString.Substring(myString.Length-4)+myString.Length)+myString.Substring(myString.Length-4));
                //Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
                Console.WriteLine(myString.Length < 4 ? myString + myString + myString : 
                    myString.Substring(myString.Length - 4) +
                    myString.Substring(myString.Length - 4) + 
                    myString.Substring(myString.Length - 4) + 
                    myString.Substring(myString.Length - 4));
            }
            CreateNewStringOf4CopiesWithLast4CharactersFromAGivenString();
        }

        //33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
        public static void CheckIfTheGivenPositiveNumberIsMultipleOr3Or7()
        {
            Console.Write("Write a positive number: ");
            //string positiveString = Convert.ToString(Console.ReadLine());
            int positiveNumber = Convert.ToInt32(Console.ReadLine());

            if (positiveNumber > 0)
            {
                if (positiveNumber % 3 == 0)
                {
                    Console.WriteLine("The number is multiple of 3.\n");
                }
                else if (positiveNumber % 7 == 0)
                {
                    Console.WriteLine("The number is multiple of 7.\n");
                }
                else
                {
                    Console.WriteLine("The number is neither a multiple of 3 nor a multiple of 7.\n");
                }
            }
            //else if (positiveString == "Exit")
            //{
            //    Console.Write("Incorrect format.");
            //}
            else
            {
                Console.WriteLine("Write a positive number.\n");
            }
            CheckIfTheGivenPositiveNumberIsMultipleOr3Or7();
        }

        //34. Write a C# program to check if a string starts with a specified word.
        public static bool MatchStartingString()
        {
            /*
             Note: Suppose the sentence starts with "Hello"
                Sample Data: string1 = "Hello how are you?"
                Result: Hello.
                Sample Output:
                Input a string : Hello how are you?
                True
             */
            Console.Write("Your string: ");
            string yourString = Console.ReadLine();

            Console.Write("Matching string: ");
            string matchingString = Console.ReadLine();

            if (yourString.StartsWith(matchingString))
            {
                Console.Write("True\n");
                MatchStartingString();
                //return true;
            }
            else
            {
                Console.Write("False\n");
            }
            MatchStartingString();
            return false;
        }
        public static void MatchStartingString1()
        {
            //string str;
            //Console.Write("Input a string : ");
            //str = Console.ReadLine();
            //Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
         
            Console.Write("Your string: ");
            string yourString = Console.ReadLine();

            Console.Write("Matching string: ");
            string matchingString = Console.ReadLine();

            Console.WriteLine(yourString.Length < matchingString.Length && yourString.Equals(matchingString) ||
                yourString.StartsWith(matchingString) && yourString[yourString.Length - 1] == ' ');
            MatchStartingString1();
            
        }

        //35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
        public static void Check2NumbersIfLessOrGreaterThanRespectively100And200()
        {
            /*
             Sample Output:
                Input a first number(<100): 75
                Input a second number(>100): 250
                True
             */
            Console.Write("Input first number (<100) : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number (>200) : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNumber < 100 && secondNumber > 200);

            Check2NumbersIfLessOrGreaterThanRespectively100And200();
        }

        //36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10
        public static void CheckIfTheGivenIntegerIsInTheRangeFromMinus10To10()
        {
            /*
             Sample Output:
                Input a first number: -5
                Input a second number: 8
                True
             */
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer :");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((firstInteger >= -10 && firstInteger <= 10)||(secondInteger >= -10 && secondInteger <= 10));
            //Console.WriteLine();

            if(firstInteger>=-10 && firstInteger <= 10)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            if(secondInteger>=-10 && secondInteger <= 10)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            CheckIfTheGivenIntegerIsInTheRangeFromMinus10To10();
        }

        //37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". 
        public static void CheckIfHPAppearsAt2ndPositionInAStringAndReturnsTheStringWithoutHP()
        {
            /*
             Test Data: PHP Tutorial
                Sample Output:
                P Tutorial
             */

            Console.Write("String : ");
            string givenString = Console.ReadLine();

            Console.WriteLine(givenString.Substring(1, 2).Equals("HP") ? givenString.Remove(1, 2) : givenString);

            //Console.WriteLine(givenString.Substring(0, 1).Equals("GH") ? givenString.Remove(0, 1) : givenString);

            CheckIfHPAppearsAt2ndPositionInAStringAndReturnsTheStringWithoutHP();
        }

        //38. Write a C# program to get a new string of two characters from a given string. The first and second character
        //of the given string must be "P" and "H", so PHP will be "PH".
        public static void GetNewStringOf2CharactersFromAGivenString()
        {
            Console.Write("First string: ");
            string firstString = Console.ReadLine();
            var result = "";

            if (firstString.Length >= 1 && firstString[0] == 'P')
                result += firstString[0];
            else if (firstString.Length >= 2 && firstString[1] == 'H')
                result += firstString[1];
            Console.WriteLine(result);
        }

        //39. Write a C# program to find the largest and lowest values from three integer values.
        public static void FindLargestAndLowestValuesfrom3IntegerValues()
        {
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third integer : ");
            int thirdInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(firstInteger, Math.Max(secondInteger, thirdInteger)));
            //Console.WriteLine("Lowest of three: " + Math.Min(firstInteger, Math.Min(secondInteger, thirdInteger)));
            Console.WriteLine("Lowest of three: " + Math.Min(secondInteger, Math.Min(firstInteger, thirdInteger)));
        }

        //40. Write a C# program to check the nearest value of 20 of two given integers and
        //return 0 if two numbers are same.
        public static void CheckNearestValueOf20Of2GivenIntegersAndReturns0If2NumbersAreSame()
        {
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            int givenValue = 20;

            if (givenValue - firstInteger < givenValue - secondInteger)
                Console.WriteLine("Nearest value is: " + firstInteger);
            else if (givenValue - firstInteger > givenValue - secondInteger)
                Console.WriteLine("Nearest value is: " + secondInteger);
            else
                Console.WriteLine("0");
        }

        //41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
        public static void CheckIfGivenStringContainsACharacterWBetween1And3Times()
        {
            Console.Write("Your string: ");
            string yourString = Console.ReadLine();
            var count = yourString.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);

            /*
                s => s == 'w' is Predicate delegate with lambda expression,
                str.Count(s => s == 'w') simply counts the occurences of the characters w
                
                str.Count(s => s == 'w') is basically a shortened way to say this:
                ------------------------------------------------------------------
                    result = 0;
                    foreach (char s in str)
                    {
                        if (s == 'w')
                        {
                            result += 1;
                        }
                    }
                    return result;
             
             */

        }

        //42. Write a C# program to create a new string where the first 4 characters will be in lower case.
        //If the string is less than 4 characters then make the whole string in upper case.
        public static void CreateNewStringWhereFirst4CharactersWillBeInLowerCase()
        {
            Console.Write("String is : ");
            string str = Console.ReadLine();

            if (str.Length < 4)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));

            CreateNewStringWhereFirst4CharactersWillBeInLowerCase();
        }

        //43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww"
        public static void CheckIfGivenStringStartsWithW()
        {
            Console.Write("String :");
            string str = Console.ReadLine();

            if (str.StartsWith('w'))
                Console.WriteLine("ww" + str);
        }

        //44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
        public static void CreateNewStringOfEveryOtherCharacterFromTheFirstPositionOfGivenString()
        {
            Console.Write("Input string : ");
            string inputString = Console.ReadLine();
            var result = string.Empty;

            for(var i=0; i<inputString.Length; i++)
            {
                if(i%2==0)
                {
                    result += inputString[i];
                }
            }
            Console.WriteLine(result);
        }

        //45. Write a C# program to count a specified number in a given array of integers.
        public static void CountSpecifiedNumberInGivenArrayOfInteger()
        {
            Console.Write("Write an integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] num = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.Write("The number " + x + " is present in the said array for ");
            Console.Write(num.Count(a => a == x));
            Console.WriteLine(" times.");

            CountSpecifiedNumberInGivenArrayOfInteger();
        }

        //46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
        public static void CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore()
        {
            Console.WriteLine("Write a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] integers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            int firstInteger = integers.ElementAt(0);
            int totalElements = integers.Length;
            int lastInteger = totalElements - 1;
            lastInteger = integers.ElementAt(14);
            //int lastInteger = integers.ElementAt(14);

            if (number == firstInteger)
            {
                Console.WriteLine("The number appears as the first element of the said array.");
            }
            else if(number == lastInteger)
            {
                Console.WriteLine("The number appears as the last element of the said array.");
            }
            else
            {
                Console.WriteLine("This is not a valid input.");
            }

            CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore();
        }

        public static void CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore1()
        {
            Console.WriteLine("Write an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine(nums[0]==x||(nums[nums.Length-1]==x));

            CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore1();
        }

        //47. Write a C# program to compute the sum of all the elements of an array of integers.
        public static void ComputeTheSumOfAllTheElementsOfAnArrayOfIntegers()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var sum = 0;

            for(var i=0; i<nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("Sum : " +sum);
        }

        //48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
        public static void CheckIfFirstElementAndLastElementAreEqualOfAnArrayOfIntegersAndTheLengthIs1OrMore()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            int firstElement = nums[0];
            int lastElement = nums[nums.Length - 1];

            if(firstElement==lastElement)
                Console.WriteLine("The first element and the last element are equal");
            if(nums.Length==1)
                Console.WriteLine("The length is 1");
            if(nums.Length>1)
                Console.WriteLine("The length is more than 1");

            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));


        }

        //49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
        public static void CheckIfFirstOrLastElementOfTwoArraysAreEqual()
        {
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
            int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("\nArray2 : [{0}]", string.Join(", ", nums2));

            Console.WriteLine("check if the first element or the last element of the two arrays ( length 1 or more) are equal.");
            Console.WriteLine((nums1[0].Equals(nums2[0]))||(nums1[nums1.Length-1].Equals(nums2[nums2.Length-1])));
        }

        //50. Write a C# program to rotate an array (length 3) of integers in left direction.
        public static void RotateArrayOfIntegersInLeftDirection()
        {
            int[] nums = { 5, 2, 8 };
            Console.Write("\nArray1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for(var i=0; i<nums.Length-1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;

            Console.Write("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
        }

        //51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
        public static void GetLargerValueBetweenFirstAndLastElementOfAnArrayOfIntegers()
        {
            int[] nums = { 5, 2, 8 };
            Console.Write("\nArray1: [{0}]", string.Join(", ", nums));
            var h_val = nums[0];

            for(var i=0; i<nums.Length; i++)
            {
                if (nums[i] > nums[0])
                {
                    h_val = nums[i];
                }
            }
            Console.Write("\nHighest value between the first and last values of the said array is: {0}", h_val);
        }

        //52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
        public static void CreateNewArrayContainingMiddleElementsOfThreeArraysOfIntegers()
        {
            int[] arr1 = { 2, 5, 8, 9, 13 };
            int[] arr2 = { 3, 6, 9, 10, 14 };
            int[] arr3 = { 1, 4, 7, 11, 15 };

            int middleElementOfArr1 = arr1[(arr1.Length - 1) / 2];
            //int newArr1 = Convert.ToInt32(Console.ReadLine(middleArrayOfArr1));
            int middleElementOfArr2 = arr2[(arr2.Length - 1) / 2];
            int middleElementOfArr3 = arr3[(arr3.Length - 1) / 2];

            int[] resultedArray = { middleElementOfArr1, middleElementOfArr2, middleElementOfArr3 };
            Console.Write("\nResulted array: [{0}]", string.Join(", ", resultedArray));
        }

        //53. Write a C# program to check if an array contains an odd number.
        public static void CheckIfAnArrayContainsAnOddNumber()
        {
            int[] nums = { 1, 2, 3, 43, 22, 44, 66, 88, 76, 77, 57, 79, 97, 99 };

            foreach (var item in nums)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item + " is an odd number");
                }
            }
        }
        //Bookish solution:
        public static void CheckIfAnArrayContainsAnOddNumber1()
        {
            int[] nums = { 2, 4, 7, 8, 6 };
            Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));

            static bool even_odd(int[] nums)
            {
                foreach (var n in nums)
                {
                    if (n % 2 != 0)
                        return true;
                }
                return false;
            }
        }

        //54. Write a C# program to get the century from a year.
        public static void GetCenturyFromAYear()
        {
            int[] year = { 110, 1200, 1000, 1500, 2000 };

            foreach (var item in year)
            {
                int century = item / 100;
                if (item % 100 == 0)
                {
                    Console.WriteLine("The year " + item + " is " + century + " century.");
                }
                else
                {
                    Console.WriteLine("The year " + item + " is NOT a century." );
                }
            }
        }

        //55. Write a C# program to find the pair of adjacent elements that has the largest product of a
        //given array which is equal to a given value.
        public static void FindThePairOfAdjacentElementsHavingLargestProductOfAGivenArrayWhichIsEqualToAGivenValue()
        {

        }
    }

}
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            Console.WriteLine("{0}{0}{0}", inputNumber);
            Console.WriteLine("{0} {0}", inputNumber);
            Console.WriteLine("{0} {0}", inputNumber);
            Console.WriteLine("{0} {0}", inputNumber);
            Console.WriteLine("{0}{0}{0}", inputNumber);

            //for(int i=0; i<=4; i++)
            //{
            //    Console.Write("{0}", inputNumber);
            //    for (int j=0; j<=1; j++)
            //    {
            //        Console.Write("{0}", inputNumber);
            //    }
            //    Console.WriteLine();

            //    for (i = 1; i <= 2; i++)
            //    {
            //        Console.Write("{0}", inputNumber);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
        }

        //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
        public static void ConvertFromCelciusToKelvinAndFarenheit()
        {
            /*Test Data:
                Enter the amount of celsius: 30
                Expected Output:
                Kelvin = 303
                Fahrenheit = 86*/
            Console.Write("Celcius : ");
            decimal celcius = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("kelvin =  {0}", celcius + 273);
            //Console.ReadLine();

            Console.WriteLine("farenheit = {0}", celcius * 18 / 10 + 32);
            //Console.ReadLine();
        }

        //15. Write a C# program to remove a specified character from a non-empty string using index of a character.
        public static void RemoveSpecifiedCharacterFromNonEmptyStringUsingIndexOfACharacter()
        {        /*
          * Test Data:
            w3resource
            Sample Output:
            wresource
            w3resourc
            3resource
        */
            Console.WriteLine("Write your string : ");
            string yourString = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Write the index you want to remove your string from : ");
            int yourIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(RemoveSpecifiedCharacter(yourString, yourIndex));
            Console.WriteLine();
            Console.WriteLine(RemoveSpecifiedCharacter("Reaz U Ahmed", 8));
            Console.WriteLine(RemoveSpecifiedCharacter("Reaz U Ahmed", 17));

            static string RemoveSpecifiedCharacter(string specifiedCharacter, int num1)
            {
                if(num1 !< specifiedCharacter.Length)
                {
                    return specifiedCharacter.Remove(num1);
                }
                else
                {
                    return "The index you specified is beyond the limit of your string!";
                }
            }
            RemoveSpecifiedCharacterFromNonEmptyStringUsingIndexOfACharacter();
        }

        //16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        public static void CreateNewStringFromGivenStringWhereFirstAndLastCharChangePosition()
        {
            /*
             Test Data:
                w3resource
                Python
                Sample Output:
                e3resourcw
                nythoP
                x
             */
            Console.Write("Give your string : ");
            string givenString = Console.ReadLine();

            Console.WriteLine(First_Last(givenString));

            static string First_Last(string ustr)
            {
                return ustr.Length > 1
                    ? ustr.Substring(ustr.Length - 1) +
                    ustr.Substring(1, ustr.Length - 2) +
                    ustr.Substring(0, 1) : ustr;
            }
            CreateNewStringFromGivenStringWhereFirstAndLastCharChangePosition();
        }

        //17. Write a C# program to create a new string from a given string (length 1 or more) with the first character added at the front and back.
        //i.e. Reaz will become RReaz and ReazR
        public static void CreateNewStringFromGivenStringWithFirstCharAddedAtFrontAndBack()
        {
            /*
             Sample Output:
                Input a string : The quick brown fox jumps over the lazy dog.
                TThe quick brown fox jumps over the lazy dog.T
             */
            Console.Write("Given String : ");
            string ustr = Console.ReadLine();

            if (ustr.Length >= 1)
            {
                var s = ustr.Substring(0, 1);
                Console.WriteLine(s + ustr + s);
            }

        }

        //18. Write a C# program to check two given integers and return true if one is negative and one is positive.
        public static void Check2GivenIntersAndReturnTruIfOneIsNegativeAndOneIsPositive()
        {
            /*
             Sample Output:
                Input first integer:
                -5
                Input second integer:
                25
                Check if one is negative and one is positive:
                True
             */
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            if (firstInteger < 1)
            {
                Console.WriteLine("True");
            }
            else if (secondInteger < 1)
            {
                Console.WriteLine("False");
            }
            else if (firstInteger == 1111 || secondInteger == 9999)
            {
                Environment.Exit(0);
                //Application.Exit();
            }
            else
            {
                Console.WriteLine("Not a vlaid input...");
            }
            Check2GivenIntersAndReturnTruIfOneIsNegativeAndOneIsPositive();
        }

        //19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
        public static void ComputeSumOf2GivenIntegersIf2ValuesAreEqualReturnTripleOfTheirSum()
        {
            Console.WriteLine("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            int sum = firstInteger + secondInteger;
            Console.WriteLine("Sum of 2 integers : " + sum);

            if(firstInteger == secondInteger)
            {
                Console.WriteLine("Triple of two given integers : " + sum * 3);
            }
        }

        //20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the
        //absolute value of the difference if the first number is greater than second number
        public static void GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum()
        {
            Console.Write("First number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int absoluteValue = firstNumber - secondNumber;

            if(absoluteValue < 0)
            {
                absoluteValue = -absoluteValue;
                Console.Write("Absolute value : " + absoluteValue);
            }
            Console.WriteLine();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Double the absolute value : " + absoluteValue);
            }
            Console.WriteLine();
            GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum();
        }

        //20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the
        //absolute value of the difference if the first number is greater than second number
        public static void GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum_1()
        {
            Console.Write("First number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result(firstNumber, secondNumber));

            static int result(int num1, int num2)
            {
                if (num1 > num2)
                {
                    Console.Write("Double the absolute value of difference between first and second numbers : ");
                    return (num1 - num2) * 2;
                }
                Console.Write("Absolute value of difference between first and second numbers : ");
                return num2 - num1;
            }
            GetAbsoluteValueOfDiffBetween2GivenNumbersReturnDoubleTheAbsoluteValueOfDiffIfFistNumGreaterThanSecondNum_1();
        }

        //21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
        public static void CheckSumOfTwoGivenIntegersAndReturnTrueIfOneIntegerIs20OrTheirSumIs20()
        {
            Console.Write("First integer : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum=num1+num2;

            sum = num1 + num2;
            if (num1 == 20 || num2 == 20 || sum == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            CheckSumOfTwoGivenIntegersAndReturnTrueIfOneIntegerIs20OrTheirSumIs20();
        }

        //22. Write a C# program to check if a given integer is within 20 of 100 or 200.
        public static void CheckIfGivenIntegerIsWithin20Of100Or200()
        {
            /*
             Sample Output:
                Input an integer:
                25
                False
             */
            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));

            static bool result(int n)
            {
                if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                    return true;
                return false;
            }
            CheckIfGivenIntegerIsWithin20Of100Or200();
        }

        //23. Write a C# program to convert a given string into lowercase.
        public static void ConvertGivenStringIntoLowerCase()
        {
            Console.Write("Input the string : ");
            string givenString = Console.ReadLine();

            Console.WriteLine(ConvertIntoLowerCase(givenString));

            static string ConvertIntoLowerCase(string s)
            {
                return s.ToLower();
            }
            ConvertGivenStringIntoLowerCase();
        }

        //24. Write a C# program to find the longest word in a string.
        public static void FindLongestWordInString()
        {
            Console.Write("Write a string that contains a group of words : ");
            string line = Console.ReadLine();

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            
            foreach(string s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }

        //25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
        public static void PrintOddNumbersFrom1to99()
        {
            /*
             Sample Output:
                Odd numbers from 1 to 99. Prints one number per line.
                1
                3
                5
                7
                9
                ...
                95
                97
                99
             */
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int x = 1; x<(num+1); x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x.ToString());
                }
            }
            PrintOddNumbersFrom1to99();
        }

        //26. Write a C# program to compute the sum of the first 500 prime numbers.
        public static void ComputeSumOfFirst500PrimeNumbers()
        {
            /*
             Sample Output:
                Sum of the first 500 prime numbers:
                824693
             */

            Console.Write("Enter the number you wanted to get the sum of the first 500 prime numbers : ");
            long number = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Sum of the first 500 prime numbers : ");
            long sum = 0;
            int ctr = 0;
            int n = 2;

            //while (ctr < 500)
            while (ctr < number)
            {
                if (IsPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum.ToString());
            
            static bool IsPrime(int n)
            {
                int x = (int)Math.Floor(Math.Sqrt(n));

                if (x == 1) return false;
                if (x == 2) return true;

                for(int i=2; i<=x; ++i)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }

        //27. Write a C# program and compute the sum of the digits of an integer.
        public static void ComputeSumOfDigitsOfAnInteger()
        {
            Console.Write("Input an integer : ");
            int input = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }
            Console.WriteLine("Sum of the digits of said integer : " + sum);

            ComputeSumOfDigitsOfAnInteger();
        }

        //28. Write a C# program to reverse the words of a sentence
        public static void ReverseTheWordsOfASentence()
        {
            /*
             Sample Output:
                Original String: Display the pattern like pyramid using the alphabet.
                Reverse String: alphabet. the using pyramid like pattern the Display
             */
            Console.Write("Original String : ");
            string sentence = Console.ReadLine();
            //Console.WriteLine("Original String : " + sentence);

            string result = "";

            List<string> wordList = new List<string>();
            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);

            for(int i = words.Length-1; i>=0; i--)
            {
                result += words[i] + " ";
            }
            wordList.Add(result);

            foreach(string s in wordList)
            {
                Console.WriteLine("Reverse String : " + s);
            }
        }

        //29. Write a C# program to find the size of a specified file in bytes.
        public static void FindSizeOfFileInBytes()
        {
            /*
             Sample Output:
                Size of a file: 31
             */
            FileInfo fileInfo = new FileInfo("D:/w3resource/Basic Declarations and Expressions/Help/NumberPatterns.cs");
            Console.WriteLine("\nSize of file: " + fileInfo.Length.ToString()+ " bytes");
        }

        //30. Write a C# program to convert a hexadecimal number to decimal number.
        public static void ConvertHexaDecimalNumberToDecimalNumber()
        {
            /*
             Sample Output:
                Hexadecimal number: 4B0
                Convert to-
                Decimal number: 1200
             */
            try
            {
                Console.Write("Hexadecimal number: ");
                String hexadecimal = Convert.ToString(Console.ReadLine());
                int decimalValue = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber);

                Console.Write("Convert to-");
                Console.WriteLine("Decimal number : " + decimalValue);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

            ConvertHexaDecimalNumberToDecimalNumber();
        }

        //31. Write a C# program to multiply corresponding elements of two arrays of integers.
        public static void MultiplyCorrespondingElementsOfTwoArraysOfIntegers()
        {
            /*
             Sample Output:
                Array1: [1, 3, -5, 4]
                Array2: [1, 4, -5, -2]
                Multiply corresponding elements of two arrays:
                1 12 25 -8
             */

            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(" ", first_array));
            Console.WriteLine("\nArray2: [{0}]", string.Join(" ", second_array));

            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            for(int i=0; i<first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        //32. Write a C# program to create a new string of four copies, taking last four characters from a given string.
        //If the length of the given string is less than 4 return the original one.
        public static void CreateNewStringOf4CopiesWithLast4CharactersFromAGivenString()
        {
            /*
             Sample Output:
                Input a string : The quick brown fox jumps over the lazy dog.
                dog.dog.dog.dog.
             */
            Console.Write("Write your string: ");
            //The quick brown fox jumps over the lazy dog.
            string myString = Console.ReadLine();

            if (myString.Length > 4)
            {
                //Console.WriteLine(myString.Length<4? myString + myString + myString:myString.Substring(myString.Length-4)+myString.Substring(myString.Length-4)+myString.Length)+myString.Substring(myString.Length-4));
                //Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
                Console.WriteLine(myString.Length < 4 ? myString + myString + myString : 
                    myString.Substring(myString.Length - 4) +
                    myString.Substring(myString.Length - 4) + 
                    myString.Substring(myString.Length - 4) + 
                    myString.Substring(myString.Length - 4));
            }
            CreateNewStringOf4CopiesWithLast4CharactersFromAGivenString();
        }

        //33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
        public static void CheckIfTheGivenPositiveNumberIsMultipleOr3Or7()
        {
            Console.Write("Write a positive number: ");
            //string positiveString = Convert.ToString(Console.ReadLine());
            int positiveNumber = Convert.ToInt32(Console.ReadLine());

            if (positiveNumber > 0)
            {
                if (positiveNumber % 3 == 0)
                {
                    Console.WriteLine("The number is multiple of 3.\n");
                }
                else if (positiveNumber % 7 == 0)
                {
                    Console.WriteLine("The number is multiple of 7.\n");
                }
                else
                {
                    Console.WriteLine("The number is neither a multiple of 3 nor a multiple of 7.\n");
                }
            }
            //else if (positiveString == "Exit")
            //{
            //    Console.Write("Incorrect format.");
            //}
            else
            {
                Console.WriteLine("Write a positive number.\n");
            }
            CheckIfTheGivenPositiveNumberIsMultipleOr3Or7();
        }

        //34. Write a C# program to check if a string starts with a specified word.
        public static bool MatchStartingString()
        {
            /*
             Note: Suppose the sentence starts with "Hello"
                Sample Data: string1 = "Hello how are you?"
                Result: Hello.
                Sample Output:
                Input a string : Hello how are you?
                True
             */
            Console.Write("Your string: ");
            string yourString = Console.ReadLine();

            Console.Write("Matching string: ");
            string matchingString = Console.ReadLine();

            if (yourString.StartsWith(matchingString))
            {
                Console.Write("True\n");
                MatchStartingString();
                //return true;
            }
            else
            {
                Console.Write("False\n");
            }
            MatchStartingString();
            return false;
        }
        public static void MatchStartingString1()
        {
            //string str;
            //Console.Write("Input a string : ");
            //str = Console.ReadLine();
            //Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
         
            Console.Write("Your string: ");
            string yourString = Console.ReadLine();

            Console.Write("Matching string: ");
            string matchingString = Console.ReadLine();

            Console.WriteLine(yourString.Length < matchingString.Length && yourString.Equals(matchingString) ||
                yourString.StartsWith(matchingString) && yourString[yourString.Length - 1] == ' ');
            MatchStartingString1();
            
        }

        //35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
        public static void Check2NumbersIfLessOrGreaterThanRespectively100And200()
        {
            /*
             Sample Output:
                Input a first number(<100): 75
                Input a second number(>100): 250
                True
             */
            Console.Write("Input first number (<100) : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number (>200) : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNumber < 100 && secondNumber > 200);

            Check2NumbersIfLessOrGreaterThanRespectively100And200();
        }

        //36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10
        public static void CheckIfTheGivenIntegerIsInTheRangeFromMinus10To10()
        {
            /*
             Sample Output:
                Input a first number: -5
                Input a second number: 8
                True
             */
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer :");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((firstInteger >= -10 && firstInteger <= 10)||(secondInteger >= -10 && secondInteger <= 10));
            //Console.WriteLine();

            if(firstInteger>=-10 && firstInteger <= 10)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            if(secondInteger>=-10 && secondInteger <= 10)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            CheckIfTheGivenIntegerIsInTheRangeFromMinus10To10();
        }

        //37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". 
        public static void CheckIfHPAppearsAt2ndPositionInAStringAndReturnsTheStringWithoutHP()
        {
            /*
             Test Data: PHP Tutorial
                Sample Output:
                P Tutorial
             */

            Console.Write("String : ");
            string givenString = Console.ReadLine();

            Console.WriteLine(givenString.Substring(1, 2).Equals("HP") ? givenString.Remove(1, 2) : givenString);

            //Console.WriteLine(givenString.Substring(0, 1).Equals("GH") ? givenString.Remove(0, 1) : givenString);

            CheckIfHPAppearsAt2ndPositionInAStringAndReturnsTheStringWithoutHP();
        }

        //38. Write a C# program to get a new string of two characters from a given string. The first and second character
        //of the given string must be "P" and "H", so PHP will be "PH".
        public static void GetNewStringOf2CharactersFromAGivenString()
        {
            Console.Write("First string: ");
            string firstString = Console.ReadLine();
            var result = "";

            if (firstString.Length >= 1 && firstString[0] == 'P')
                result += firstString[0];
            else if (firstString.Length >= 2 && firstString[1] == 'H')
                result += firstString[1];
            Console.WriteLine(result);
        }

        //39. Write a C# program to find the largest and lowest values from three integer values.
        public static void FindLargestAndLowestValuesfrom3IntegerValues()
        {
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third integer : ");
            int thirdInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(firstInteger, Math.Max(secondInteger, thirdInteger)));
            //Console.WriteLine("Lowest of three: " + Math.Min(firstInteger, Math.Min(secondInteger, thirdInteger)));
            Console.WriteLine("Lowest of three: " + Math.Min(secondInteger, Math.Min(firstInteger, thirdInteger)));
        }

        //40. Write a C# program to check the nearest value of 20 of two given integers and
        //return 0 if two numbers are same.
        public static void CheckNearestValueOf20Of2GivenIntegersAndReturns0If2NumbersAreSame()
        {
            Console.Write("First integer : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second integer : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            int givenValue = 20;

            if (givenValue - firstInteger < givenValue - secondInteger)
                Console.WriteLine("Nearest value is: " + firstInteger);
            else if (givenValue - firstInteger > givenValue - secondInteger)
                Console.WriteLine("Nearest value is: " + secondInteger);
            else
                Console.WriteLine("0");
        }

        //41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
        public static void CheckIfGivenStringContainsACharacterWBetween1And3Times()
        {
            Console.Write("Your string: ");
            string yourString = Console.ReadLine();
            var count = yourString.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);

            /*
                s => s == 'w' is Predicate delegate with lambda expression,
                str.Count(s => s == 'w') simply counts the occurences of the characters w
                
                str.Count(s => s == 'w') is basically a shortened way to say this:
                ------------------------------------------------------------------
                    result = 0;
                    foreach (char s in str)
                    {
                        if (s == 'w')
                        {
                            result += 1;
                        }
                    }
                    return result;
             
             */

        }

        //42. Write a C# program to create a new string where the first 4 characters will be in lower case.
        //If the string is less than 4 characters then make the whole string in upper case.
        public static void CreateNewStringWhereFirst4CharactersWillBeInLowerCase()
        {
            Console.Write("String is : ");
            string str = Console.ReadLine();

            if (str.Length < 4)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));

            CreateNewStringWhereFirst4CharactersWillBeInLowerCase();
        }

        //43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww"
        public static void CheckIfGivenStringStartsWithW()
        {
            Console.Write("String :");
            string str = Console.ReadLine();

            if (str.StartsWith('w'))
                Console.WriteLine("ww" + str);
        }

        //44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
        public static void CreateNewStringOfEveryOtherCharacterFromTheFirstPositionOfGivenString()
        {
            Console.Write("Input string : ");
            string inputString = Console.ReadLine();
            var result = string.Empty;

            for(var i=0; i<inputString.Length; i++)
            {
                if(i%2==0)
                {
                    result += inputString[i];
                }
            }
            Console.WriteLine(result);
        }

        //45. Write a C# program to count a specified number in a given array of integers.
        public static void CountSpecifiedNumberInGivenArrayOfInteger()
        {
            Console.Write("Write an integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] num = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.Write("The number " + x + " is present in the said array for ");
            Console.Write(num.Count(a => a == x));
            Console.WriteLine(" times.");

            CountSpecifiedNumberInGivenArrayOfInteger();
        }

        //46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
        public static void CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore()
        {
            Console.WriteLine("Write a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] integers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            int firstInteger = integers.ElementAt(0);
            int totalElements = integers.Length;
            int lastInteger = totalElements - 1;
            lastInteger = integers.ElementAt(14);
            //int lastInteger = integers.ElementAt(14);

            if (number == firstInteger)
            {
                Console.WriteLine("The number appears as the first element of the said array.");
            }
            else if(number == lastInteger)
            {
                Console.WriteLine("The number appears as the last element of the said array.");
            }
            else
            {
                Console.WriteLine("This is not a valid input.");
            }

            CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore();
        }

        public static void CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore1()
        {
            Console.WriteLine("Write an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine(nums[0]==x||(nums[nums.Length-1]==x));

            CheckIfTheNumberAppearsAsFirstOrLastElementOfTheArrayOfIntegersAndTheLengthIs1OrMore1();
        }

        //47. Write a C# program to compute the sum of all the elements of an array of integers.
        public static void ComputeTheSumOfAllTheElementsOfAnArrayOfIntegers()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var sum = 0;

            for(var i=0; i<nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("Sum : " +sum);
        }

        //48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
        public static void CheckIfFirstElementAndLastElementAreEqualOfAnArrayOfIntegersAndTheLengthIs1OrMore()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            int firstElement = nums[0];
            int lastElement = nums[nums.Length - 1];

            if(firstElement==lastElement)
                Console.WriteLine("The first element and the last element are equal");
            if(nums.Length==1)
                Console.WriteLine("The length is 1");
            if(nums.Length>1)
                Console.WriteLine("The length is more than 1");

            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));


        }

        //49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
        public static void CheckIfFirstOrLastElementOfTwoArraysAreEqual()
        {
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
            int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("\nArray2 : [{0}]", string.Join(", ", nums2));

            Console.WriteLine("check if the first element or the last element of the two arrays ( length 1 or more) are equal.");
            Console.WriteLine((nums1[0].Equals(nums2[0]))||(nums1[nums1.Length-1].Equals(nums2[nums2.Length-1])));
        }

        //50. Write a C# program to rotate an array (length 3) of integers in left direction.
        public static void RotateArrayOfIntegersInLeftDirection()
        {
            int[] nums = { 5, 2, 8 };
            Console.Write("\nArray1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for(var i=0; i<nums.Length-1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;

            Console.Write("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
        }

        //51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
        public static void GetLargerValueBetweenFirstAndLastElementOfAnArrayOfIntegers()
        {
            int[] nums = { 5, 2, 8 };
            Console.Write("\nArray1: [{0}]", string.Join(", ", nums));
            var h_val = nums[0];

            for(var i=0; i<nums.Length; i++)
            {
                if (nums[i] > nums[0])
                {
                    h_val = nums[i];
                }
            }
            Console.Write("\nHighest value between the first and last values of the said array is: {0}", h_val);
        }

    }

}
>>>>>>> c67f94af85be523b214d5df9fb15c4077c6db384
