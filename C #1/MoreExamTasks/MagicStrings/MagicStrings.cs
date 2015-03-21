using System;

class Program
{
    public static int Weight(string sequence)
    {
        int weight = 0;
        foreach(var ch in sequence)
        {
            switch(ch)
            {
                case 's': weight += 3; break;
                case 'n': weight += 4; break;
                case 'k': weight += 1; break;
                case 'p': weight += 5; break;
            }
        }
        return weight;
    }
    static void Main(string[] args)
    {
        int diff = int.Parse(Console.ReadLine());

        int result = 0;
        char[] letter = { 'k', 'n', 'p', 's' };

        for (int i1 = 0; i1 < letter.Length; i1++)
        {
            for (int i2 = 0; i2 < letter.Length; i2++)
            {
                for (int i3 = 0; i3 < letter.Length; i3++)
                {
                    for (int i4 = 0; i4 < letter.Length; i4++)
                    {
                        string left = "" + letter[i1] + letter[i2] + letter[i3] + letter[i4];
                        int weightLeft = Weight(left);
                        for (int i5 = 0; i5 < letter.Length; i5++)
                        {
                            for (int i6 = 0; i6 < letter.Length; i6++)
                            {
                                for (int i7 = 0; i7 < letter.Length; i7++)
                                {
                                    for (int i8 = 0; i8 < letter.Length; i8++)
                                    {
                                        string right = "" + letter[i5] + letter[i6] + letter[i7] + letter[i8];
                                       int weightRight = Weight(right);
                                        if(Math.Abs(weightLeft-weightRight)==diff)
                                        {
                                            Console.WriteLine(left+right);
                                            result++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if(result==0)
        {
            Console.WriteLine("No");
        }
    }
}

