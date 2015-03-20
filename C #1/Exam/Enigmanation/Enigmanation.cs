using System;


class Enigmanation
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        double result = 0;
        char operation = '+';
        char bracketOperator = '+';
        bool bracket= false;
        double bracketScore = 0;
        int lengthEq = userInput.Length;
        for (int i = 0; i < lengthEq; i++)
        {
            if(bracket)
            {
                if(userInput[i]=='+' || userInput[i]=='-' || userInput[i]=='*' || userInput[i]=='%')
                {
                    bracketOperator = userInput[i];
                }
                else if(userInput[i] > '0' && userInput[i]<'9')
                {
                    switch(bracketOperator)
                    {
                        case '+':
                            bracketScore += double.Parse(userInput[i].ToString());
                            break;
                        case '-':
                            bracketScore -= double.Parse(userInput[i].ToString());
                            break;
                        case '*':
                            bracketScore *= double.Parse(userInput[i].ToString());
                            break;
                        case '%':
                            bracketScore %= double.Parse(userInput[i].ToString());
                            break;
                    }
                }
                else if(userInput[i]==')')
                {
                    bracket = false;
                    switch (operation)
                    {
                        case '+':
                            bracketScore += bracketScore;
                            break;
                        case '-':
                            bracketScore -=bracketScore;
                            break;
                        case '*':
                            bracketScore *= bracketScore;
                            break;
                        case '%':
                            bracketScore %= bracketScore;
                            break;
                    }
                    bracketScore=0;
                }
            }
            else
            {
                if(userInput[i]=='(')
                {
                    bracket = true;
                    bracketOperator = '+';
                }
                else if(userInput[i]>='0' && userInput[i]<='9')
                {
                    switch (operation)
                    {
                        case '+':
                            bracketScore += bracketScore;
                            break;
                        case '-':
                            bracketScore -= bracketScore;
                            break;
                        case '*':
                            bracketScore *= bracketScore;
                            break;
                        case '%':
                            bracketScore %= bracketScore;
                            break;
                    }
                }
                else if(userInput[i]=='+' || userInput[i]=='-' || userInput[i]=='*' || userInput[i]=='%')
                {
                    operation = userInput[i];
                }
            }
        }
        Console.WriteLine("{0:F3}", result);
    }
}



//using System;
//using System.Text;
//class Progra
//{
//    static void Main()
//    {
//        StringBuilder longExam = new StringBuilder(Console.ReadLine());
//        decimal sum = 0;
//        char symbol = '+';
//        StringBuilder number = new StringBuilder();
//        for (int i = 0; i < longExam.Length; i++)
//        {
//            if (longExam[i] >= '0' && longExam[i] <= '9')
//            {
//                number.Append(longExam[i]);
//            }
//            else if (longExam[i] == '+' || longExam[i] == '-' || longExam[i] == '*' || longExam[i] == '%')
//            {
//                sum = Calculate(sum, decimal.Parse(number.ToString()), symbol);
//                number = new StringBuilder();
//                symbol = longExam[i];
//            }
//            else if (longExam[i] == '(')
//            {
//                string current = InScope(longExam, ref i);
//                number.Append(current);
//            }
//            else if (longExam[i] == '=')
//            {
//                sum = Calculate(sum, int.Parse(number.ToString()), symbol);
//            }
//        }
//        Console.WriteLine("{0:0.000}", sum);
 
//    }
 
//    private static string InScope(StringBuilder longExam, ref int i)
//    {
//        StringBuilder number = new StringBuilder();
//        decimal sum = 0;
//        char symbol = '+';
//        i++;
//        while (longExam[i] != ')')
//        {
//            if (longExam[i] >= '0' && longExam[i] <= '9')
//            {
//                number.Append(longExam[i]);
//            }
//            else if (longExam[i] == '+' || longExam[i] == '-' || longExam[i] == '*' || longExam[i] == '%')
//            {
//                sum = Calculate(sum, decimal.Parse(number.ToString()), symbol);
//                number = new StringBuilder();
//                symbol = longExam[i];
//            }
//            i++;
//        }
//        sum = Calculate(sum, decimal.Parse(number.ToString()), symbol);
//        return sum.ToString();
//    }
 
//    private static decimal Calculate(decimal sum, decimal p, char symbol)
//    {
//        if (symbol == '+')
//        {
//            return sum + p;
//        }
//        else if (symbol == '-')
//        {
//            return sum - p;
//        }
//        else if (symbol == '%')
//        {
//            return sum % p;
//        }
//        return sum * p;
//    }
//}