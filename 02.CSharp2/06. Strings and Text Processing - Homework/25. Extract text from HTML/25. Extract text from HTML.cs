//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical  training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        Console.WriteLine(input);

        //Get the contents of a <title></title> tag
        string pattern = "(<title.*>)(.*)(<\\/title>)";
        string title = Regex.Match(input, pattern).ToString();
        title = Regex.Replace(title, @"<.*?>", String.Empty);
        Console.WriteLine("Title: {0}", title);

        //Get the contents of a <body></body> tag
        pattern = "(<body.*>)(.*)(<\\/body>)";
        string body = Regex.Match(input, pattern).ToString();
        body = Regex.Replace(body, @"<.*?>", " ");              //Replace html tags in the body with spaces
        body = body.Trim();                                     //Trim the string
        body = Regex.Replace(body, @"\s+", " ");                //Replace multiple spaces with single space
        Console.WriteLine(" Body: {0}", body);
    }
}

