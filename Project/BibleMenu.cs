using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // <summary>
    /// Класс создает меню для Библейского шифра
    /// </summary>
    public static class BibleMenu
    {
        /// <summary>
        /// Метод для отображения пунктов меню для Библейского шифра
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
                    Action = () => MenuHelper.ExecuteMenu(MainMenu.options),
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
▄▄▄▄    ██▓ ▄▄▄▄    ██▓    ▓█████ 
▓█████▄ ▓██▒▓█████▄ ▓██▒    ▓█   ▀ 
▒██▒ ▄██▒██▒▒██▒ ▄██▒██░    ▒███   
▒██░█▀  ░██░▒██░█▀  ▒██░    ▒▓█  ▄ 
░▓█  ▀█▓░██░░▓█  ▀█▓░██████▒░▒████▒
░▒▓███▀▒░▓  ░▒▓███▀▒░ ▒░▓  ░░░ ▒░ ░
▒░▒   ░  ▒ ░▒░▒   ░ ░ ░ ▒  ░ ░ ░  ░
 ░    ░  ▒ ░ ░    ░   ░ ░      ░   
 ░       ░   ░          ░  ░   ░  ░
      ░           ░                ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое зашифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            BibleCipher bibleCipher = new BibleCipher();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Зашифрованное сообщение: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            bibleCipher.EncryptDecrypt(input);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Нажмите на пробел чтобы вернуться");
            ConsoleKeyInfo keyinfo;

            do
            {
                keyinfo = Console.ReadKey(true);
            } while (keyinfo.Key != ConsoleKey.Spacebar);
        }
        /// <summary>
        /// Метод для отображения пунктов меню при расшифровании сообщения
        /// </summary>
        public static void Decrypt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@"
▄▄▄▄    ██▓ ▄▄▄▄    ██▓    ▓█████ 
▓█████▄ ▓██▒▓█████▄ ▓██▒    ▓█   ▀ 
▒██▒ ▄██▒██▒▒██▒ ▄██▒██░    ▒███   
▒██░█▀  ░██░▒██░█▀  ▒██░    ▒▓█  ▄ 
░▓█  ▀█▓░██░░▓█  ▀█▓░██████▒░▒████▒
░▒▓███▀▒░▓  ░▒▓███▀▒░ ▒░▓  ░░░ ▒░ ░
▒░▒   ░  ▒ ░▒░▒   ░ ░ ░ ▒  ░ ░ ░  ░
 ░    ░  ▒ ░ ░    ░   ░ ░      ░   
 ░       ░   ░          ░  ░   ░  ░
      ░           ░                ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое расшифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            BibleCipher bibleCipher = new BibleCipher();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Расшифрованное сообщение: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            bibleCipher.EncryptDecrypt(input);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

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

