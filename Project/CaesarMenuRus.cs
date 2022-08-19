using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Создает меню для шифра Цезаря на русском языке
    /// </summary>
    public static class CaesarMenuRus
    {
        /// <summary>
        /// Метод для отображения пунктов меню для шифра Цезаря
        /// </summary>
        public static List<MenuOption> options = new List<MenuOption>()
            {
                new MenuOption()
                {
                    Title = "Зашифровать",
                    Action = Encrypt,
                },
                new MenuOption()
                {
                    Title = "Расшифровать",
                    Action = Decrypt,
                },
                new MenuOption()
                {
                    Title = "Назад",
                    Action = () => MenuHelper.ExecuteMenu(CaesarMenu.options),
                },
            };
        /// <summary>
        /// Метод для отображения пунктов меню при шифровании сообщения
        /// </summary>
        public static void Encrypt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
▄████▄   ▄▄▄      ▓█████   ██████  ▄▄▄       ██▀███  
▒██▀ ▀█  ▒████▄    ▓█   ▀ ▒██    ▒ ▒████▄    ▓██ ▒ ██▒
▒▓█    ▄ ▒██  ▀█▄  ▒███   ░ ▓██▄   ▒██  ▀█▄  ▓██ ░▄█ ▒
▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒▓█  ▄   ▒   ██▒░██▄▄▄▄██ ▒██▀▀█▄  
▒ ▓███▀ ░ ▓█   ▓██▒░▒████▒▒██████▒▒ ▓█   ▓██▒░██▓ ▒██▒
░ ░▒ ▒  ░ ▒▒   ▓▒█░░░ ▒░ ░▒ ▒▓▒ ▒ ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░
  ░  ▒     ▒   ▒▒ ░ ░ ░  ░░ ░▒  ░ ░  ▒   ▒▒ ░  ░▒ ░ ▒░
░          ░   ▒      ░   ░  ░  ░    ░   ▒     ░░   ░ 
░ ░            ░  ░   ░  ░      ░        ░  ░   ░     
░                                                     ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое зашифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите число ключа для шифрования: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string newInput = Console.ReadLine();
            bool result = int.TryParse(newInput, out var key);
            if (result == false)
            {
                Console.WriteLine("Был введен недопустимый символ");
            }
            else
            {
                CaesarCipher caesarCipher = new CaesarCipher();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Зашифрованное сообщение: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                caesarCipher.EncrypRU(input, key);

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(new string('*', Console.WindowWidth));
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Нажмите на пробел чтобы вернуться");
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey(true);
            } while (keyinfo.Key != ConsoleKey.Spacebar);
        }
        /// <summary>
        /// Метод для расшифровки сообщения от шифра Цезаря
        /// </summary>
        public static void Decrypt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
▄████▄   ▄▄▄      ▓█████   ██████  ▄▄▄       ██▀███  
▒██▀ ▀█  ▒████▄    ▓█   ▀ ▒██    ▒ ▒████▄    ▓██ ▒ ██▒
▒▓█    ▄ ▒██  ▀█▄  ▒███   ░ ▓██▄   ▒██  ▀█▄  ▓██ ░▄█ ▒
▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒▓█  ▄   ▒   ██▒░██▄▄▄▄██ ▒██▀▀█▄  
▒ ▓███▀ ░ ▓█   ▓██▒░▒████▒▒██████▒▒ ▓█   ▓██▒░██▓ ▒██▒
░ ░▒ ▒  ░ ▒▒   ▓▒█░░░ ▒░ ░▒ ▒▓▒ ▒ ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░
  ░  ▒     ▒   ▒▒ ░ ░ ░  ░░ ░▒  ░ ░  ▒   ▒▒ ░  ░▒ ░ ▒░
░          ░   ▒      ░   ░  ░  ░    ░   ▒     ░░   ░ 
░ ░            ░  ░   ░  ░      ░        ░  ░   ░     
░                                                     ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое расшифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите число ключа для шифрования: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string newInput = Console.ReadLine();
            bool result = int.TryParse(newInput, out var key);
            if (result == false)
            {
                Console.WriteLine("Был введен недопустимый символ");
            }
            else
            {
                CaesarCipher caesarCipher = new CaesarCipher();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Зашифрованное сообщение: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                caesarCipher.DecrypRU(input, key);

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(new string('*', Console.WindowWidth));
            }
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Нажмите на пробел чтобы вернуться");
            ConsoleKeyInfo keyinfo;

            do
            {
                keyinfo = Console.ReadKey(true);
            } while (keyinfo.Key != ConsoleKey.Spacebar);
        }
    }
}
