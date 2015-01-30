using System;
//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("The program prints information about current company: ");
        Console.WriteLine("Please enter the name of the company: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter the company adress: ");
        string adress = Console.ReadLine();
        Console.WriteLine("Please enter the company phone number: ");
        int phoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the company fax number: ");
        int faxNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the company web site: ");
        string webSite= Console.ReadLine();
        Console.WriteLine("Please enter the manager's first name: ");
        string FirstName= Console.ReadLine();
        Console.WriteLine("Please enter the manager's last name: ");
        string lastName= Console.ReadLine();
        Console.WriteLine("Please enter manager's age ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the manager's phone number: ");
        int managersPhoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(name);
        Console.WriteLine("Adress {0}", adress);
        Console.WriteLine("Tel: {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Maneger: {0} (age: {1}, tel.{2})", FirstName, lastName, managersPhoneNumber);
    }
}

