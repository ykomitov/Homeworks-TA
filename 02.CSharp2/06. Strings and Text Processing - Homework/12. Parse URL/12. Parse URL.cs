/*•	Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource] and extracts from it the [protocol],
 * [server] and [resource] elements.*/

using System;

class ParseURL
{
    static void Main()
    {
        Uri input = new Uri ("http://telerikacademy.com/Courses/Courses/Details/212");

        Console.WriteLine(input);
        Console.WriteLine("\r\n[protocol] = {0}", input.Scheme);
        Console.WriteLine("[server] = {0}", input.Host);
        Console.WriteLine("[resource] = {0}\r\n", input.AbsolutePath);
    }
}
