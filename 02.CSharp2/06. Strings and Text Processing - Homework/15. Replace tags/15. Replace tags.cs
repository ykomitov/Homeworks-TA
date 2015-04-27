//•	Write a program that replaces in a HTML document given as string all the tags
//  <a href="…">…</a> with corresponding tags [URL=…]…/URL].

/*<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>*/

/*<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>*/

//replace <a href=" with [URL=
//replace ">        with ]
//replace </a>      with [/URL]

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string document = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string s = String.Empty;
        Console.WriteLine(document);
        s = Regex.Replace(document,@"<a href=""","[URL=");
        s = Regex.Replace(s, @""">", "]");
        s = Regex.Replace(s, @"</a>", "[/URL]");
        Console.WriteLine(s);
    }
}

