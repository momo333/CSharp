using System;
class Program
{
    static void Main(string[] args)
    {
        int shift = 64;
        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;
        string secMember = Console.ReadLine();
        int second = secMember[0] - shift;
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine((char)(first) + shift);
        if (rows > 1)
        {
            int next = first + second;
            if (next > 26)
            {
                next %= 26;
            }
            string result = ((char)(second + shift)).ToString()
                + ((char)(next + shift)).ToString();
            Console.WriteLine(result);
            first = second;
            second = next;
            for (int i = 3; i <=rows; i++)
            {
                next = first + second;
                first = second;
                second = first;
                if (next > 26)
                {
                    next %= 26;
                }
                next = first + second;
                first = second;
                second = first;
                if (next > 26)
                {
                    next %= 26;
                }
                Console.Write((char)(first) + shift);
                Console.Write(new string(' ', i - 2));
                Console.Write((char)(second) + shift);
            }
        }

    }
}





//class Program
//{
//    static void Main(string[] args)
//    {
//        char one = char.Parse(Console.ReadLine());
//        char two = char.Parse(Console.ReadLine());
//        int numAnacci = int.Parse(Console.ReadLine());
//        int[] arrAnacci = new int[numAnacci+1];
//        int space = 0;
//        int codeFirst =0;
//        int codeSec =0;
//        int number = 0;

//        char[] array = new char[] {' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 
//            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
//        int length = array.Length;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (one == array[i])
//            {
//                codeFirst = i;
//            }
//            if (two == array[i])
//            {
//                codeSec = i;
//            }
//        }
//        arrAnacci[0] = codeFirst;
//        arrAnacci[1] = codeFirst;
//        Console.WriteLine(array[codeFirst]);

//        for (int i = 2; i <= numAnacci; i++)
//        {

//            number = codeFirst + codeSec;
//            arrAnacci[i] = number;
//            if(number >26)
//            {
//                number %= 26;
//            }
//            codeFirst = codeSec;   //3,2  --> C, B ,E, G, L 
//            codeSec = number;     //5, 7, 9
//            number = codeFirst + codeSec;
//            arrAnacci[i] = number;
//            if(number >26)
//            {
//                number %= 26;
//            }
//            codeFirst = codeSec;   //3,2  --> C, B ,E, G, L 
//            codeSec = number; 
//        }

//        for (int i = 2; i < arrAnacci.Length; i++)
//        {
//            space++;
//            string spaceBWords = new string(' ', space);
//            Console.WriteLine("{0}{1}{2}",array[arrAnacci[i-1]], spaceBWords, array[arrAnacci[i]]);
//        }

//    }
//}

