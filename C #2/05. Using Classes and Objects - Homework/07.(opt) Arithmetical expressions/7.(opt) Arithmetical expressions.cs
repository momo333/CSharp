using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
/*•	Write a program that calculates the value of given arithmetical expression.
          •	The expression can contain the following elements only:
            o	Real numbers, e.g. 5, 18.33, 3.14159, 12.6
            o	Arithmetic operators: +, -, *, / (standard priorities)
            o	Mathematical functions: ln(x), sqrt(x), pow(x,y)
            o	Brackets (for changing the default priorities): (, )*/
class CalculateExpression
{
    static Dictionary<string, int> precedence = new Dictionary<string, int>() { { "+", 2 }, { "-", 2 }, { "*", 4 }, { "/", 4 }, { "ln", 8 }, { "pow", 8 }, { "sqrt", 8 } };
    static Stack<string> operators = new Stack<string>();
    static Queue<string> numbers = new Queue<string>();

    static bool IsNumber(char next)
    {
        switch (next)
        {
            case '1': return true;

            case '2': return true;

            case '3': return true;

            case '4': return true;

            case '5': return true;

            case '6': return true;

            case '7': return true;

            case '8': return true;

            case '9': return true;

            case '0': return true;

            case '.': return true;

            default: return false;
        }
    }

    static bool IsOpp(char next)
    {
        switch (next)
        {
            case '+': return true;

            case '-': return true;

            case '/': return true;

            case '*': return true;

            default: return false;
        }
    }

    static string ShuntingYard(String s)
    {
        // optimization for negative numbers
        if (s.Contains(", -"))
            s = s.Replace(", -", ", 0-");
        if (s.Contains(",-"))
            s = s.Replace(",-", ",0-");
        if (s.Contains("( -"))
            s = s.Replace("( -", "( 0-");
        if (s.Contains("(-"))
            s = s.Replace("(-", "(0-");
        // Console.WriteLine(s);

        StringBuilder number = new StringBuilder("");
        for (int i = 0; i < s.Length; i++)
        {
            char next = s.ElementAt(i);
            if (next == ' ')
                continue;

            if (IsNumber(next))
            {
                number.Append(next);
                if (i == s.Length - 1)
                {
                    number.Append(" ");
                    string num = number.ToString();
                    numbers.Enqueue(num);
                    number.Clear();
                }
            }
            else
            {
                if (number.Length > 0 || i == s.Length - 1)
                {
                    number.Append(" ");
                    string num = number.ToString();
                    numbers.Enqueue(num);
                    number.Clear();
                }
                if (next == 'l')
                {
                    string fn = "" + s.ElementAt(i) + s.ElementAt(i + 1);
                    operators.Push(fn);
                }
                else if (next == 'p')
                {
                    string fn = "" + s.ElementAt(i) + s.ElementAt(i + 1) + s.ElementAt(i + 2);
                    operators.Push(fn);
                }
                else if (next == 's')
                {
                    string fn = "" + s.ElementAt(i) + s.ElementAt(i + 1) + s.ElementAt(i + 2) + s.ElementAt(i + 3);
                    operators.Push(fn);
                }
                else if (next == ',')
                {
                    while (operators.Peek() != "(")
                    {
                        numbers.Enqueue(operators.Pop() + " ");
                    }
                }
                else if (IsOpp(next))
                {
                    int value1;
                    int value2;
                    precedence.TryGetValue(next.ToString(), out value1);
                    while (operators.Count > 0)
                    {
                        precedence.TryGetValue(operators.Peek(), out value2);
                        if (value1 <= value2 && next.ToString() != operators.Peek())
                        {
                            numbers.Enqueue(operators.Pop() + " ");
                        }
                        else
                            break;
                    }
                    string opp = next.ToString();
                    operators.Push(opp);
                    continue;
                }
                else if (next == '(')
                {
                    operators.Push(next.ToString());
                }
                else if (next == ')')
                {
                    while (operators.Peek() != "(")
                    {
                        numbers.Enqueue(operators.Pop() + " ");
                    }
                    if (operators.Peek() == "(")
                    {
                        operators.Pop();
                    }
                    if (operators.Count > 0 && (operators.Peek() == "ln" || operators.Peek() == "pow" || operators.Peek() == "sqrt"))
                    {
                        numbers.Enqueue(operators.Pop() + " ");
                    }
                }
            }
        }
        while (operators.Count > 0)
        {
            numbers.Enqueue(operators.Pop() + " ");
        }
        StringBuilder result = new StringBuilder(s.Length);
        foreach (var item in numbers)
        {
            result.Append(item);
        }
        return result.ToString();
    }

    static string ReversedPolish(List<string> token)
    {
        for (int i = 0; i < token.Count; i++)
        {
            string temp = "";
            switch (token[i])
            {
                case "+":
                    temp = (double.Parse(token[i - 1]) + double.Parse(token[i - 2])).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 2, 2);
                    ReversedPolish(token);
                    break;
                case "-": temp = (double.Parse(token[i - 2]) - double.Parse(token[i - 1])).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 2, 2);
                    ReversedPolish(token);
                    break;
                case "/": temp = (double.Parse(token[i - 2]) / double.Parse(token[i - 1])).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 2, 2);
                    ReversedPolish(token);
                    break;
                case "*": temp = (double.Parse(token[i - 2]) * double.Parse(token[i - 1])).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 2, 2);
                    ReversedPolish(token);
                    break;
                case "ln": temp = (Math.Log(double.Parse(token[i - 1]))).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 1, 1);
                    ReversedPolish(token);
                    break;
                case "sqrt": temp = (Math.Sqrt(double.Parse(token[i - 1]))).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 1, 1);
                    ReversedPolish(token);
                    break;
                case "pow": temp = (Math.Pow(double.Parse(token[i - 2]), double.Parse(token[i - 1]))).ToString();
                    token[i] = temp;
                    token.RemoveRange(i - 2, 2);
                    ReversedPolish(token);
                    break;
                default:
                    break;
            }
        }
        return token[0];
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine(); //"(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) ";

        Console.WriteLine("The string: " + s);
        Console.WriteLine();
        string result = ShuntingYard(s);
        Console.WriteLine("Reversed Polish Notation: " + result);
        Console.WriteLine();
        string[] array = result.Split(' ');
        List<string> token = array.ToList<string>();
        Console.WriteLine("Result: " + ReversedPolish(token));
        Console.WriteLine();
    }
}


