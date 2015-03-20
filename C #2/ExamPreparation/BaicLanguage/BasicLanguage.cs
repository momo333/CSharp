using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaicLanguage
{
    class BasicLanguage
    {
        private static StringBuilder output = new StringBuilder();
        private static List<string> allCommands = new List<string>();
        static void Main(string[] args)
        {
            ReadInput();
            ConvertInputCommands();
            RunCommands();
            Console.WriteLine(output.ToString());
        }

        private static void ConvertInputCommands()
        {
            string input = output.ToString();
            output.Clear();
            foreach (var symbol in input)
            {
                output.Append(symbol);
                {
                    if (symbol == ';')
                    {
                        allCommands.Add(output.ToString());
                        output.Clear();
                    }

                }
            }
        }
        private static void RunCommands()
        {
            output.Clear();
            for (int i = 0; i < allCommands.Count; i++)
            {
                int loops = 0;
                string[] subCommand = allCommands[i].Split(new char[] { ')' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var command in subCommand)
                {
                    string currComand = command.TrimStart();
                    if (currComand.StartsWith("EXIT"))
                    {
                        return;
                    }
                    else if (currComand.StartsWith("PRINT"))
                    {
                        int parmsStart = currComand.IndexOf("(") + 1;
                        string content = currComand.Substring(parmsStart);
                        for (int j = 0; j < loops; j++)
                        {
                            output.Append(content);
                        }

                    }
                    else if (currComand.StartsWith("FOR"))
                    {
                        int parmsStart = currComand.IndexOf("(") + 1;
                        string allParams = currComand.Substring(parmsStart);
                        if (allParams.Contains(","))
                        {
                            string[] loopParams = allParams.Split(',');
                            int a = int.Parse(loopParams[0]);
                            int b = int.Parse(loopParams[1]);
                            loops *= (b - a + 1);
                        }
                        else
                        {
                            int value = int.Parse(allParams);
                            loops *= value;
                        }
                    }

                }
            }
        }
        private static void ReadInput()
        {
            while (true)
            {
                string line = Console.ReadLine();
                output.AppendLine(line);
                if (line.Contains("Exit;"))
                {
                    break;
                }
            }

        }
    }
}
