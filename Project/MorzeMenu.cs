using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания меню к Азбуке Морзе
    /// </summary>
    public static class MorzeMenu
    {
        /// <summary>
        /// Метод создает языковые пункты для выбора пользователем  
        /// </summary>
        public static List<MenuOption> options = new List<MenuOption>()
            {
                new MenuOption()
                {
                    Title = "Английский язык",
                    Action = Eng,
                },
                new MenuOption()
                {
                    Title = "Русский язык",
                    Action = Rus,
                },
                new MenuOption()
                {
                    Title = "Назад",
                    Action = () => MenuHelper.ExecuteMenu(MainMenu.options),
                },
            };
        /// <summary>
        /// Выводит пункты меню азбуки Морзе при выборе английского языка 
        /// </summary>
        public static void Eng()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@"
███▄ ▄███▓ ▒█████   ██▀███  ▒███████▒▓█████ 
▓██▒▀█▀ ██▒▒██▒  ██▒▓██ ▒ ██▒▒ ▒ ▒ ▄▀░▓█   ▀ 
▓██    ▓██░▒██░  ██▒▓██ ░▄█ ▒░ ▒ ▄▀▒░ ▒███   
▒██    ▒██ ▒██   ██░▒██▀▀█▄    ▄▀▒   ░▒▓█  ▄ 
▒██▒   ░██▒░ ████▓▒░░██▓ ▒██▒▒███████▒░▒████▒
░ ▒░   ░  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░▒▒ ▓░▒░▒░░ ▒░ ░
░  ░      ░  ░ ▒ ▒░   ░▒ ░ ▒░░░▒ ▒ ░ ▒ ░ ░  ░
░      ░   ░ ░ ░ ▒    ░░   ░ ░ ░ ░ ░ ░   ░   
       ░       ░ ░     ░       ░ ░       ░  ░
                             ░               ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое зашифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            MorzeCipher morzeCipher = new MorzeCipher();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Зашифрованное сообщение: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            morzeCipher.MorzEng(input);

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
        /// Выводит пункты меню азбуки Морзе при выборе русского языка 
        /// </summary>
        public static void Rus()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@"
███▄ ▄███▓ ▒█████   ██▀███  ▒███████▒▓█████ 
▓██▒▀█▀ ██▒▒██▒  ██▒▓██ ▒ ██▒▒ ▒ ▒ ▄▀░▓█   ▀ 
▓██    ▓██░▒██░  ██▒▓██ ░▄█ ▒░ ▒ ▄▀▒░ ▒███   
▒██    ▒██ ▒██   ██░▒██▀▀█▄    ▄▀▒   ░▒▓█  ▄ 
▒██▒   ░██▒░ ████▓▒░░██▓ ▒██▒▒███████▒░▒████▒
░ ▒░   ░  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░▒▒ ▓░▒░▒░░ ▒░ ░
░  ░      ░  ░ ▒ ▒░   ░▒ ░ ▒░░░▒ ▒ ░ ▒ ░ ░  ░
░      ░   ░ ░ ░ ▒    ░░   ░ ░ ░ ░ ░ ░   ░   
       ░       ░ ░     ░       ░ ░       ░  ░
                             ░               ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Введите cообщение необходимое зашифровать: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();

            EasterEgg synopsis = new EasterEgg();

            if (input == "2703")
            {
                synopsis.Piano();   
            }
            else
            {
                MorzeCipher morzeCipher = new MorzeCipher();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Зашифрованное сообщение: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                morzeCipher.MorzRus(input);

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
}

