using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    public class Example_5_GetMd5Hash
    {
        public static void Run()
        {
            string shortInput = "Hello";
            string longInput = new string('a', 1000000000); // 1 миллиард символов 'a'

            string shortHash = GetMd5Hash(shortInput);
            string longHash = GetMd5Hash(longInput);

            Console.WriteLine($"MD5 хеш для короткого текста: {shortHash}");
            Console.WriteLine($"MD5 хеш для длинного текста: {longHash}");
        }

        static string GetMd5Hash(string input)
        {
            // Создаем экземпляр MD5
            using (MD5 md5 = MD5.Create())
            {
                // Преобразуем строку в массив байтов
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                // Вычисляем хеш
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Преобразуем массив байтов в шестнадцатеричную строку
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2")); // Преобразование байтов в шестнадцатеричный формат
                }
                return sb.ToString(); // Возвращение хеша в виде строки
            }
        }
    }
}

//MD5 хеш для короткого текста: 8B1A9953C4611296A827ABF8C47804D7
//MD5 хеш для длинного текста: C9FAD513774BD938134C288576BD93CC