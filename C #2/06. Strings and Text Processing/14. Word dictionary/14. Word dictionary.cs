using System;
/*•	A dictionary is stored as a sequence of text lines containing words and 
* their explanations. •	Write a program that enters a word and translates it by using the dictionary.*/
class WordDictionary
{
    static void Main()
    {
        string[,] dictionary = new string[,]{{".NET","platform for applications from Microsoft" },
                                             {"CLR", "managed execution environment for .NET"},
                                             {"namespace", "hierarchical organization of classes"}};
        string word = Console.ReadLine();
        for (int i = 0; i < dictionary.GetLength(0); i++)
			{
			 for (int j = 0; j < dictionary.GetLength(1); j++)
			    {
			            if(word==dictionary[i,j])
                        {
                            Console.WriteLine("{0} - {1}", word, dictionary[i,j+1]);
                        }
			    }
			}

    }
}
