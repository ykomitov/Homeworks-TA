//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Linq;
using System.Text.RegularExpressions;

class SubStringInText
{
    static void Main()
    {
        string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eu enim vel lorem ultrices commodo sed vitae magna. Aenean maximus vehicula neque. Vivamus quis magna sit amet est ullamcorper viverra. Maecenas quis feugiat quam. Praesent eu semper est, sit amet auctor dolor. Etiam tincidunt orci sit amet tellus commodo dapibus. Vestibulum felis nunc, sodales sit amet sodales at, elementum tincidunt tortor. Mauris nibh massa, consequat a augue non, ornare pretium ex. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris massa justo, efficitur in eros nec, euismod sagittis leo. Sed condimentum, metus quis gravida tristique, metus massa lobortis justo, vel pellentesque enim urna non nisl. Aenean auctor mi nec metus pulvinar, quis consectetur massa euismod. Praesent facilisis lorem placerat ultrices porta. Sed sed enim porttitor, placerat mauris eu, hendrerit nulla.\r\nInterdum et malesuada fames ac ante ipsum primis in faucibus. Nunc ullamcorper lectus eleifend sapien elementum, ut sagittis sapien sagittis. Sed egestas, justo sit amet interdum ullamcorper, nunc turpis consectetur dui, eu tincidunt nunc lectus sit amet dolor. Nullam sed elit mattis, facilisis magna eget, consequat est. Sed tincidunt at felis vel semper. Maecenas sapien risus, molestie eget tortor et, hendrerit facilisis est. Nullam ac placerat ex.";
        
        //Check for given substring using regular expressions
        string check = "eu";
        int count = Regex.Matches(input, check).Count;

        Console.WriteLine("{0} is repeated {1} time(s) in the string.", check, count);
    }
}

