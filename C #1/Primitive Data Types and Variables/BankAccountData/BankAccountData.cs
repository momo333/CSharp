using System;
//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.


class BankAccount
{
    static void Main()
    {
        string firstName = "First name";
        string middleName = "Middle name";
        string lastName = "Third name";
        decimal amountMoney = 1000.01m;
        string bankName = "DSK";
        string iban = "BG01 UBWS 1000 1000 100 00";
        long cardNumber1 = 100000000000000;
        long cardNumber2 = 200000000000000;
        long cardNumber3 = 300000000000000;
        Console.WriteLine("{0} \n{1} \n{2}\nAvailable amount of money(balance): {3}\n{4} IBAN: {5}\nCard number 1: {6}\nCard number 2: {7}\nCard number 3: {8}", 
            firstName, middleName, lastName, amountMoney, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
        }
    }
    
