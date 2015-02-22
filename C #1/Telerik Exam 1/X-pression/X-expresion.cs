using System;
using System.Collections.Generic;


namespace X_pression
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<double> numbers = new List<double>();
            List<char> mathOperators = new List<char>();
            double resultBracket = 0;
            List<double> numBracket = new List<double>();
            List<char> matOperBrack = new List<char>();
            int numBrack = 0;
            for (int index = 0; index < input.Length; index++)
            {
                if(char.IsDigit(input[index]))
                {
                    numbers.Add(Convert.ToDouble(Convert.ToInt32(input[index] - 48)));
                }
                if(input[index]=='+'||input[index]=='-'||input[index]=='*'||input[index]=='%' )
                {
                    mathOperators.Add(input[index]);
                }
                if(input[index]=='(')
                {
                    numBrack = index;
                    numBracket.Clear();
                    mathOperators.Clear();
                    while(input[numBrack]!=')')
                    {
                        if(char.IsDigit(input[numBrack]))
                        {
                            numBracket.Add(Convert.ToDouble(Convert.ToInt32(input[numBrack])));
                        }
                        if(input[numBrack]=='+'|| input[numBrack]=='-'||input[numBrack]=='*'||
                            input[numBrack]=='%')
                        {
                            matOperBrack.Add(input[numBrack]);
                        }
                        numBrack++;
                    }
                    resultBracket = numBracket[0];
                    for (int i = 0; i < matOperBrack.Count; i++)
                    {
                        switch(matOperBrack[i])
                        {
                            case'+':
                                resultBracket += numBracket[i + 1]; 
                                break;
                            case '-': 
                                resultBracket -= numBracket[i + 1]; 
                                break;
                            case '*':
                                resultBracket *= numBracket[i + 1];
                                break;
                            case '%':
                                resultBracket %= numBracket[i + 1];
                                break;

                        }
                        numbers.Add(resultBracket);
                        index = numBrack;
                    }
                }
                double result = numBracket[0];
                for (int k = 0; k < mathOperators.Count; k++)
                {
                    switch (mathOperators[k])
                    {
                        case '+':
                            result += numbers[k+1];
                            break;
                        case '-':
                            result -= numbers[k + 1];
                            break;
                        case '*':
                            result *= numbers[k + 1];
                            break;
                        case '%':
                            result %= numbers[k + 1];
                            break;
                    }
                }
                Console.WriteLine("{0:F3}", result);
            }

        }
    }
}
