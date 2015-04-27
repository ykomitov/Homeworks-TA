/*•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the 
 * current directory.
  •	Find in Google how to download files in C#.
  •	Be sure to catch all exceptions and to free any used resources in the finally block.*/

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "ninja-success.png");
                Console.WriteLine("Saved at {0}.", Directory.GetCurrentDirectory());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught!\n{0}:{1}", ex.GetType().Name, ex.Message); 
        }
    }
}

