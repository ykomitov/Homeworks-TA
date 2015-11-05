namespace _04.HashTableImplementation
{
    using System;

    public static class HelperMethods
    {
        public static string GetRandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var stringChars = new char[random.Next(1, 30)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            if (random.Next(2, 22) % 2 == 0)
            {
                Array.Reverse(stringChars);
            }

            return new string(stringChars);
        }
    }
}
