namespace Lesson003Task002
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(ReverseString("microsoft"));
        }

        private static string ReverseString(string input)
        {
            char[] arrChars = input.ToCharArray();

            // Можно использовать Array.Reverse(arr)
            // Для учебных целей написал for
            char[] arrCharReverse = new char[arrChars.Length];
            for (int i = arrChars.Length - 1, c = 0; i >= 0; i--, c++)
            {
                arrCharReverse[c] = arrChars[i];
            }

            return new string(arrCharReverse);
        }
    }
}