

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Text;
    public static class StringStringBuilder
    {
        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            StringBuilder subString = new StringBuilder();
            if(index + length -1>=input.Length || index<0)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            int endIndex = index + length;
            for (int i = index; i < endIndex; i++)
            {
                subString.Append(input[i]);
            }
            return subString;
        }

        public static StringBuilder SubString(this StringBuilder input, int start)
        {
            StringBuilder subString = new StringBuilder();
            if(start< 0 || start>=input.Length)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            for (int i = start; i < input.Length; i++)
            {
                subString.Append(input[i]);
            }
            return subString;
        }
    }
}
