namespace JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var jedi = Console.ReadLine();
            jedi.Trim();
            var jediArr = jedi.Split(' ');

            var jediMaster = new Queue<string>();
            var jediKnight = new Queue<string>();
            var jediPadawan = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                var currentJedi = jediArr[i];

                switch (currentJedi[0])
                {
                    case 'm': jediMaster.Enqueue(currentJedi); break;
                    case 'k': jediKnight.Enqueue(currentJedi); break;
                    case 'p': jediPadawan.Enqueue(currentJedi); break;
                    default: break;
                }
            }

            var sb = new StringBuilder();
            foreach (var jed in jediMaster)
            {
                sb.Append(jed);
                sb.Append(" ");
            }

            foreach (var jed in jediKnight)
            {
                sb.Append(jed);
                sb.Append(" ");
            }

            foreach (var jed in jediPadawan)
            {
                sb.Append(jed);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
