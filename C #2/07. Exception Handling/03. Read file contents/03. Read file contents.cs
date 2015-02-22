using System;
using System.IO;
using System.Security;
 /*•	Write a program that enters file name along with its full file path 
         * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
          •	Find in MSDN how to use System.IO.File.ReadAllText(…).
          •	Be sure to catch all possible exceptions and print user-friendly error messages.*/
class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Please enter path to the file: ");
        string filePath = Console.ReadLine();
    }
    static void PrintResult(string path)
    {
        try
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("Content of the file: ");
            Console.WriteLine(content);
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File not found! ");
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid directory!");
        }
        catch(ArgumentNullException)
        {
            Console.WriteLine("The path is not valid!");
        }
            catch(PathTooLongException)
        {
            Console.WriteLine("The path must be shorter than 248 characters!");       
        }
        catch(ArgumentException)
        {
            Console.WriteLine("The path is not valid!");
        }
        catch(UnauthorizedAccessException acessErr)
        {
            Console.WriteLine(acessErr.Message);
        }
        catch(SecurityException)
        {
            Console.WriteLine("You don't have permission to access this file!");
        }
        catch(NotSupportedException)
        {
            Console.WriteLine("Invalid Path!");
        }
        catch(IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}
