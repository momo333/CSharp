using System;
using System.Net;
using System.IO;
/*•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the 
         * current directory.
          •	Find in Google how to download files in C#.
          •	Be sure to catch all exceptions and to free any used resources in the finally block.*/

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Please enter a URL which you want to download file: ");
        Uri uri = new Uri(Console.ReadLine());
        string fileName = Path.GetFileName(uri.LocalPath);
        WebClient client = new WebClient();
        try
        {
            client.DownloadFile(uri, "../../" + fileName);
            Console.WriteLine("Download was successful.");
        }
        catch(WebException)
        {
            Console.WriteLine("Invalid adres or the file is empty.");
        }
        catch(NotSupportedException)
        {
            Console.WriteLine("");
        }
        finally
        {
            client.Dispose();
        }
    }
}

