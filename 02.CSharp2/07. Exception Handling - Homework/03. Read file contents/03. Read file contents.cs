/*•	Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
  •	Find in MSDN how to use System.IO.File.ReadAllText(…).
  •	Be sure to catch all possible exceptions and print user-friendly error messages.*/

using System;
using System.IO;


class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter full path: ");
        string path = Console.ReadLine();
        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }

        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (PathTooLongException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (NotSupportedException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
