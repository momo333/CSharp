using System;
//Problem 5. Boolean Variable

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            Console.WriteLine("the program prints the gender:");
            bool isFemale = true;

            if (isFemale)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Male");
            }
        }
    }
}
