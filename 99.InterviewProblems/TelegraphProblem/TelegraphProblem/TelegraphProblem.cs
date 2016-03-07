namespace TelegraphProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TelegraphProblem
    {
        public static void Main()
        {
            string[] rawLines = new string[] { "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." };

            string[] test = new string[] { "This is", "a sample run", "should run should not", "12 45 78 !" };

            // PrintTelegraphLines(rawLines, 14);
            PrintTelegraphLines(test, 20);
        }

        private static void PrintTelegraphLines(string[] rawLines, int n)
        {
            var telegraphLines = GetTelegraphLines(rawLines, n);

            foreach (var line in telegraphLines)
            {
                Console.WriteLine(line);
            }
        }

        private static List<string> GetTelegraphLines(string[] rawLines, int n)
        {
            List<string> wordsList = new List<string>();

            foreach (var line in rawLines)
            {
                var lineAsArr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in lineAsArr)
                {
                    wordsList.Add(word);
                }
            }

            List<string> telegraphLines = new List<string>();
            var sb = new StringBuilder();
            string previousLine = string.Empty;

            for (int i = 0; i < wordsList.Count; i++)
            {
                sb.Append(" ");
                sb.Append(wordsList[i]);

                var currentLine = sb.ToString().Trim();

                if (currentLine.Length < n)
                {
                    previousLine = currentLine;
                    continue;
                }
                else if (currentLine.Length == n)
                {
                    telegraphLines.Add(currentLine);
                    sb.Clear();
                    continue;
                }
                else
                {
                    telegraphLines.Add(previousLine);
                    sb.Clear();
                    sb.Append(wordsList[i]);
                    previousLine = sb.ToString().Trim();
                }
            }

            telegraphLines.Add(sb.ToString().Trim());

            return telegraphLines;
        }
    }
}
