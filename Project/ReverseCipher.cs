using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания шифра из Обратного шифра
    /// </summary>
    public class ReverseCipher
    {
        /// <summary>
        /// Метод, шифрующий сообщение, используя Обратный шифр
        /// </summary>
        public void ReverseEncrypt(string text)
        {
            text = text.ToLower();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Зашифрованный текст: ");
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(text[i]);
            }
        }
        /// <summary>
        /// Метод, расшифровывающий сообщение, используя Обратный шифр
        /// </summary>
        public void ReverseDecrypt(string text)
        {
            text = text.ToLower();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Расшифрованный текст: ");
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(text[i]);
            }
        }
    }
}
