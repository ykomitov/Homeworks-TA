/*Задача 1 – Двоични пароли
Ася е млада хакерка. От скоро тя се занимава с хакване на двоични пароли. Двоичните пароли са последователности от нули и единици. Ася е все още начинаещ хакер и от скоро тя може да намира части от двоични пароли. За съжаление тези пароли не са пълни и липсващите единици или нули са заместени със звездички. Така се получава една последователност от единици, нули и звездички, които образуват шаблон. Помогнете на Ася да сметне колко са възможните различни пароли, които могат да се образуват от тези шаблони. Всяка звездичка в шаблона може да бъде както единица, така и нула.

01001110    => 1
1***0       => 8
***101***   => 64

*/

namespace _01.BinaryPasswords
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var counter = 0;
            var inputAsArr = input.ToCharArray();

            foreach (var position in inputAsArr)
            {
                if (position == '*')
                {
                    counter++;
                }
            }

            ulong numberOfPasswords = (ulong)Math.Pow(2, counter);
            Console.WriteLine(numberOfPasswords);        
        }
    }
}
