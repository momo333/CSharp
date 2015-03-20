
namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
        {
            Console.OutputEncoding = Encoding.UTF8;
            char ch =  '\u00A9';
            Console.WriteLine(" " + ch);
            Console.WriteLine("{0}{1}",ch,ch);
            Console.WriteLine("{0}{1}{2}", ch, ch, ch);

        }
    }
}