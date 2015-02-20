using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a size for the sequence: ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxSequence = 0;
        int currSequence = 0;
        int SequenceNumber = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currSequence++;
            }
            else
            {
                if (currSequence > maxSequence)
                {
                    maxSequence = currSequence;
                    SequenceNumber = numbers[i];
                }
                currSequence = 1;
            }
        }
        if (currSequence > maxSequence)
        {
            maxSequence = currSequence;
            SequenceNumber = numbers[numbers.Length - 1];
        }

        Console.WriteLine("The input sequence is:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The maximum sequence is: ");
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write("{0} ", SequenceNumber);
        }
    }
}
