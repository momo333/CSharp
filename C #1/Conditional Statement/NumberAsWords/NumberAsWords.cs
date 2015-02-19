using System;
//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
class NumberAsWords
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a random number in the range [0...999].");
            string number = Console.ReadLine();
            int numberInt = int.Parse(number);
            int numberLength = number.Length;
            if (numberLength == 1)
            {
                string numberOneDigit = null;
                switch (numberInt)
                {
                    case 0: numberOneDigit = "Zero"; break;
                    case 1: numberOneDigit = "One"; break;
                    case 2: numberOneDigit = "Two"; break;
                    case 3: numberOneDigit = "Three"; break;
                    case 4: numberOneDigit = "Four"; break;
                    case 5: numberOneDigit = "Five"; break;
                    case 6: numberOneDigit = "Six"; break;
                    case 7: numberOneDigit = "Seven"; break;
                    case 8: numberOneDigit = "Eight"; break;
                    case 9: numberOneDigit = "Nine"; break;
                }
                Console.WriteLine(numberOneDigit);
            }
            else if (numberLength == 2)
            {
                string firstDigitOfTwoDigitNumIsOne = null;
                string firstDigitOfTwoDigitNum = number.Substring(0, 1);
                int firstDigitOfTwoDigitNumInt = int.Parse(firstDigitOfTwoDigitNum);
                string secondDigitOfTwoDigitNum = number.Substring(1, 1);
                int secondDigitOfTwoDigitNumInt = int.Parse(secondDigitOfTwoDigitNum);
                if (firstDigitOfTwoDigitNumInt == 1)
                {
                    switch (secondDigitOfTwoDigitNumInt)
                    {
                        case 0: firstDigitOfTwoDigitNumIsOne = "Ten"; break;
                        case 1: firstDigitOfTwoDigitNumIsOne = "Eleven"; break;
                        case 2: firstDigitOfTwoDigitNumIsOne = "Twelve"; break;
                        case 3: firstDigitOfTwoDigitNumIsOne = "Thirteen"; break;
                        case 4: firstDigitOfTwoDigitNumIsOne = "Fourteen"; break;
                        case 5: firstDigitOfTwoDigitNumIsOne = "Fifteen"; break;
                        case 6: firstDigitOfTwoDigitNumIsOne = "Sixteen"; break;
                        case 7: firstDigitOfTwoDigitNumIsOne = "Seventeen"; break;
                        case 8: firstDigitOfTwoDigitNumIsOne = "Eighteen"; break;
                        case 9: firstDigitOfTwoDigitNumIsOne = "Nineteen"; break;
                    }
                    Console.WriteLine(firstDigitOfTwoDigitNumIsOne);
                }
                if (firstDigitOfTwoDigitNumInt >= 2 && firstDigitOfTwoDigitNumInt <= 9)
                {
                    string roundTwoDigitNumber = null;
                    if (numberInt % 10 == 0)
                    {
                        switch (firstDigitOfTwoDigitNumInt)
                        {
                            case 2: roundTwoDigitNumber = "Twenty"; break;
                            case 3: roundTwoDigitNumber = "Thirty"; break;
                            case 4: roundTwoDigitNumber = "Fourty"; break;
                            case 5: roundTwoDigitNumber = "Fifty"; break;
                            case 6: roundTwoDigitNumber = "Sixty"; break;
                            case 7: roundTwoDigitNumber = "Seventy"; break;
                            case 8: roundTwoDigitNumber = "Eighty"; break;
                            case 9: roundTwoDigitNumber = "Ninety"; break;
                        }
                        Console.WriteLine(roundTwoDigitNumber);
                    }
                    else
                    {
                        switch (firstDigitOfTwoDigitNumInt)
                        {
                            case 2: firstDigitOfTwoDigitNum = "Twenty"; break;
                            case 3: firstDigitOfTwoDigitNum = "Thirthy"; break;
                            case 4: firstDigitOfTwoDigitNum = "Fourty"; break;
                            case 5: firstDigitOfTwoDigitNum = "Fifty"; break;
                            case 6: firstDigitOfTwoDigitNum = "Sixty"; break;
                            case 7: firstDigitOfTwoDigitNum = "Seventy"; break;
                            case 8: firstDigitOfTwoDigitNum = "Eighty"; break;
                            case 9: firstDigitOfTwoDigitNum = "Ninety"; break;
                        }
                        switch (secondDigitOfTwoDigitNumInt)
                        {
                            case 1: secondDigitOfTwoDigitNum = "one"; break;
                            case 2: secondDigitOfTwoDigitNum = "two"; break;
                            case 3: secondDigitOfTwoDigitNum = "three"; break;
                            case 4: secondDigitOfTwoDigitNum = "four"; break;
                            case 5: secondDigitOfTwoDigitNum = "five"; break;
                            case 6: secondDigitOfTwoDigitNum = "six"; break;
                            case 7: secondDigitOfTwoDigitNum = "seven"; break;
                            case 8: secondDigitOfTwoDigitNum = "eight"; break;
                            case 9: secondDigitOfTwoDigitNum = "nine"; break;
                        }
                        Console.WriteLine("{0} {1}", firstDigitOfTwoDigitNum, secondDigitOfTwoDigitNum);
                    }
                }
            }
            else if (numberLength == 3)
            {
                string andWord = "and";
                string firstDigitOfThreeDigitNum = number.Substring(0, 1);
                int firstDigitOfThreeDigitNumInt = int.Parse(firstDigitOfThreeDigitNum);
                string secondDigitOfThreeDigitNum = number.Substring(1, 1);
                int secondDigitOfThreeDigitNumInt = int.Parse(secondDigitOfThreeDigitNum);
                string thirdDigitOfThreeDigitNum = number.Substring(2, 1);
                int thirdDigitOfThreeDigitNumInt = int.Parse(thirdDigitOfThreeDigitNum);
                if (numberInt % 100 == 0)
                {
                    string roundThreeDigitNumber = null;
                    switch (firstDigitOfThreeDigitNumInt)
                    {
                        case 1: roundThreeDigitNumber = "One hundred"; break;
                        case 2: roundThreeDigitNumber = "Two hundred"; break;
                        case 3: roundThreeDigitNumber = "Three hundred"; break;
                        case 4: roundThreeDigitNumber = "Four hundred"; break;
                        case 5: roundThreeDigitNumber = "Five hundred"; break;
                        case 6: roundThreeDigitNumber = "Six hundred"; break;
                        case 7: roundThreeDigitNumber = "Seven hundred"; break;
                        case 8: roundThreeDigitNumber = "Eight hundred"; break;
                        case 9: roundThreeDigitNumber = "Nine hundred"; break;
                    }
                    Console.WriteLine(roundThreeDigitNumber);
                }
                else
                {
                    string secondAndThirdDigits = number.Substring(1, 2);
                    int secondAndThirdDigitsInt = int.Parse(secondAndThirdDigits);
                    switch (firstDigitOfThreeDigitNumInt)
                    {
                        case 1: firstDigitOfThreeDigitNum = "One hundred"; break;
                        case 2: firstDigitOfThreeDigitNum = "Two hundred"; break;
                        case 3: firstDigitOfThreeDigitNum = "Three hundred"; break;
                        case 4: firstDigitOfThreeDigitNum = "Four hundred"; break;
                        case 5: firstDigitOfThreeDigitNum = "Five hundred"; break;
                        case 6: firstDigitOfThreeDigitNum = "Six hundred"; break;
                        case 7: firstDigitOfThreeDigitNum = "Seven hundred"; break;
                        case 8: firstDigitOfThreeDigitNum = "Eight hundred"; break;
                        case 9: firstDigitOfThreeDigitNum = "Nine hundred"; break;
                    }
                    if (secondAndThirdDigitsInt % 10 == 0)
                    {
                        switch (secondDigitOfThreeDigitNumInt)
                        {
                            case 1: secondDigitOfThreeDigitNum = "ten"; break;
                            case 2: secondDigitOfThreeDigitNum = "twenty"; break;
                            case 3: secondDigitOfThreeDigitNum = "thirty"; break;
                            case 4: secondDigitOfThreeDigitNum = "fourty"; break;
                            case 5: secondDigitOfThreeDigitNum = "fifty"; break;
                            case 6: secondDigitOfThreeDigitNum = "sixty"; break;
                            case 7: secondDigitOfThreeDigitNum = "seventy"; break;
                            case 8: secondDigitOfThreeDigitNum = "eighty"; break;
                            case 9: secondDigitOfThreeDigitNum = "ninety"; break;
                        }
                        Console.WriteLine("{0} {1} {2}", firstDigitOfThreeDigitNum, andWord, secondDigitOfThreeDigitNum);
                    }
                    else
                    {
                        if (secondDigitOfThreeDigitNumInt == 0)
                        {
                            switch (thirdDigitOfThreeDigitNumInt)
                            {
                                case 1: thirdDigitOfThreeDigitNum = "one"; break;
                                case 2: thirdDigitOfThreeDigitNum = "two"; break;
                                case 3: thirdDigitOfThreeDigitNum = "three"; break;
                                case 4: thirdDigitOfThreeDigitNum = "four"; break;
                                case 5: thirdDigitOfThreeDigitNum = "five"; break;
                                case 6: thirdDigitOfThreeDigitNum = "six"; break;
                                case 7: thirdDigitOfThreeDigitNum = "seven"; break;
                                case 8: thirdDigitOfThreeDigitNum = "eight"; break;
                                case 9: thirdDigitOfThreeDigitNum = "nine"; break;
                            }
                            Console.WriteLine("{0} {1} {2}", firstDigitOfThreeDigitNum, andWord, thirdDigitOfThreeDigitNum);
                        }
                        if (secondDigitOfThreeDigitNumInt == 1)
                        {
                            switch (thirdDigitOfThreeDigitNumInt)
                            {
                                case 1: secondDigitOfThreeDigitNum = "eleven"; break;
                                case 2: secondDigitOfThreeDigitNum = "twelve"; break;
                                case 3: secondDigitOfThreeDigitNum = "thirteen"; break;
                                case 4: secondDigitOfThreeDigitNum = "fourteen"; break;
                                case 5: secondDigitOfThreeDigitNum = "fifteen"; break;
                                case 6: secondDigitOfThreeDigitNum = "sixteen"; break;
                                case 7: secondDigitOfThreeDigitNum = "seventeen"; break;
                                case 8: secondDigitOfThreeDigitNum = "eighteen"; break;
                                case 9: secondDigitOfThreeDigitNum = "nineteen"; break;
                            }
                            Console.WriteLine("{0} {1} {2}", firstDigitOfThreeDigitNum, andWord, secondDigitOfThreeDigitNum);
                        }
                        else if (secondDigitOfThreeDigitNumInt >= 2 && secondDigitOfThreeDigitNumInt <= 9)
                        {
                            switch (secondDigitOfThreeDigitNumInt)
                            {
                                case 2: secondDigitOfThreeDigitNum = "twenty"; break;
                                case 3: secondDigitOfThreeDigitNum = "thirty"; break;
                                case 4: secondDigitOfThreeDigitNum = "fourty"; break;
                                case 5: secondDigitOfThreeDigitNum = "fifty"; break;
                                case 6: secondDigitOfThreeDigitNum = "sixty"; break;
                                case 7: secondDigitOfThreeDigitNum = "seventy"; break;
                                case 8: secondDigitOfThreeDigitNum = "eighty"; break;
                                case 9: secondDigitOfThreeDigitNum = "ninety"; break;
                            }
                            switch (thirdDigitOfThreeDigitNumInt)
                            {
                                case 1: thirdDigitOfThreeDigitNum = "one"; break;
                                case 2: thirdDigitOfThreeDigitNum = "two"; break;
                                case 3: thirdDigitOfThreeDigitNum = "three"; break;
                                case 4: thirdDigitOfThreeDigitNum = "four"; break;
                                case 5: thirdDigitOfThreeDigitNum = "five"; break;
                                case 6: thirdDigitOfThreeDigitNum = "six"; break;
                                case 7: thirdDigitOfThreeDigitNum = "seven"; break;
                                case 8: thirdDigitOfThreeDigitNum = "eight"; break;
                                case 9: thirdDigitOfThreeDigitNum = "nine"; break;
                            }
                            Console.WriteLine("{0} {1} {2} {3}", firstDigitOfThreeDigitNum, andWord, secondDigitOfThreeDigitNum, thirdDigitOfThreeDigitNum);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}