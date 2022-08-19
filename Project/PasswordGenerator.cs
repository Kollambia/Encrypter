using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания генератора паролей
    /// </summary>
    public class PasswordGenerator
    {
        string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        Random random = new Random();
        string zero = string.Empty;
        /// <summary>
        /// Алгоритм для генератора паролей
        /// </summary>
        public void NewPasswordMaker()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите сколько символов Вы желаете видеть в своем пароле: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out var passwordLength);
            if (result != true)
            {
                Console.WriteLine($"Упс, Вы ввели недопустимый символ. Пожалуйста, в следующий раз введите цифры");
            }
            else
            {
                for (int i = 0; i < passwordLength; i++)
                {
                    zero += symbols[random.Next(0, symbols.Length)];
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.Write($"Ваш сгенерированный пароль: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(zero);
            }
        }
    }
}
