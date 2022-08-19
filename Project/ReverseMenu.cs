using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания меню для Обратного шифра
    /// </summary>
    public static class ReverseMenu
    {
        /// <summary>
        /// Метод создает пункты в меню для выбора пользователем  
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
        /// Выводит пункты меню азбуки Морзе при выборе "Зашифровать"
        /// </summary>
        public static void Encrypt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@" 
██▀███  ▓█████ ██▒   █▓▓█████  ██▀███    ██████ ▓█████ 
▓██ ▒ ██▒▓█   ▀▓██░   █▒▓█   ▀ ▓██ ▒ ██▒▒██    ▒ ▓█   ▀ 
▓██ ░▄█ ▒▒███   ▓██  █▒░▒███   ▓██ ░▄█ ▒░ ▓██▄   ▒███   
▒██▀▀█▄  ▒▓█  ▄  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄    ▒   ██▒▒▓█  ▄ 
░██▓ ▒██▒░▒████▒  ▒▀█░  ░▒████▒░██▓ ▒██▒▒██████▒▒░▒████▒
░ ▒▓ ░▒▓░░░ ▒░ ░  ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░▒ ▒▓▒ ▒ ░░░ ▒░ ░
  ░▒ ░ ▒░ ░ ░  ░  ░ ░░   ░ ░  ░  ░▒ ░ ▒░░ ░▒  ░ ░ ░ ░  ░
  ░░   ░    ░       ░░     ░     ░░   ░ ░  ░  ░     ░   
   ░        ░  ░     ░     ░  ░   ░           ░     ░  ░
                    ░                                   ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое зашифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            ReverseCipher reverseCipher = new ReverseCipher();
            reverseCipher.ReverseEncrypt(input);

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
        /// Выводит пункты меню азбуки Морзе при выборе "Расшифровать"
        /// </summary>
        public static void Decrypt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@" 
██▀███  ▓█████ ██▒   █▓▓█████  ██▀███    ██████ ▓█████ 
▓██ ▒ ██▒▓█   ▀▓██░   █▒▓█   ▀ ▓██ ▒ ██▒▒██    ▒ ▓█   ▀ 
▓██ ░▄█ ▒▒███   ▓██  █▒░▒███   ▓██ ░▄█ ▒░ ▓██▄   ▒███   
▒██▀▀█▄  ▒▓█  ▄  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄    ▒   ██▒▒▓█  ▄ 
░██▓ ▒██▒░▒████▒  ▒▀█░  ░▒████▒░██▓ ▒██▒▒██████▒▒░▒████▒
░ ▒▓ ░▒▓░░░ ▒░ ░  ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░▒ ▒▓▒ ▒ ░░░ ▒░ ░
  ░▒ ░ ▒░ ░ ░  ░  ░ ░░   ░ ░  ░  ░▒ ░ ▒░░ ░▒  ░ ░ ░ ░  ░
  ░░   ░    ░       ░░     ░     ░░   ░ ░  ░  ░     ░   
   ░        ░  ░     ░     ░  ░   ░           ░     ░  ░
                    ░                                   ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое расшифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            ReverseCipher reverseCipher = new ReverseCipher();
            reverseCipher.ReverseDecrypt(input);

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
