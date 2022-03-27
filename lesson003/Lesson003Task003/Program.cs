namespace Lesson003Task003
{
    internal class Program
    {
        private const string InputFile = "input.txt";
        private const string OutputFile = "output.txt";

        static void Main()
        {
            //Создаем файл с исходными данными
            if (!File.Exists(InputFile))
            {
                string[] lines =
                {
                    "Кучма Андрей Витальевич & kuchma@mail.ru",
                    "Мизинцев Павел Николаевич & pasha@mail.ru",
                    "Иванов Иван Иванович & ivanov@mail.ru"
                };
                File.WriteAllLines(InputFile, lines);
            }

            // TODO читаем файл
            string[] arrReadAllLines = File.ReadAllLines(InputFile);
            string[] arrEmails = new string[3];

            for (int i = 0; i < arrReadAllLines.Length; i++)
            {
                string s = arrReadAllLines[i];
                SearchEmail(ref s);
                arrEmails[i] = s;
            }

            File.WriteAllLines(OutputFile, arrEmails);
        }

        // метод парсит из строки => email
        public static void SearchEmail(ref string s)
        {
            int i = s.IndexOf("&", StringComparison.Ordinal) + 1;
            s = s.Substring(i).Trim();
        }
    }
}