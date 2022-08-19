using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для взаимодействия пользователя с меню при помощи клавиатуры
    /// </summary>
    public static class MenuHelper
    {
        /// <summary>
        /// Метод, создающий алгоритм для навигации в меню
        /// </summary>
        public static void ExecuteMenu(List<MenuOption> options)
        {
            int index = 0;
            PrintMenu(options, index);
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                    }
                    PrintMenu(options, index);
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                    }
                    PrintMenu(options, index);
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[index].Action();
                    index = 0;
                    PrintMenu(options, index);
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
        /// <summary>
        /// Метод, отвечающий за внешний вид главного меню
        /// </summary>
        static void PrintMenu(List<MenuOption> options, int index = 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("▓█████  ███▄    █  ▄████▄   ██▀███ ▓██   ██▓ ██▓███  ▄▄▄█████▓▓█████  ██▀███   ");
            Console.WriteLine("▓█   ▀  ██ ▀█   █ ▒██▀ ▀█  ▓██ ▒ ██▒▒██  ██▒▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒ ");
            Console.WriteLine("▒███   ▓██  ▀█ ██▒▒▓█    ▄ ▓██ ░▄█ ▒ ▒██ ██░▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒ ");
            Console.WriteLine("▒▓█  ▄ ▓██▒  ▐▌██▒▒▓▓▄ ▄██▒▒██▀▀█▄   ░ ▐██▓░▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄   ");
            Console.WriteLine("░▒████▒▒██░   ▓██░▒ ▓███▀ ░░██▓ ▒██▒ ░ ██▒▓░▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒ ");
            Console.WriteLine("░░ ▒░ ░░ ▒░   ▒ ▒ ░ ░▒ ▒  ░░ ▒▓ ░▒▓░  ██▒▒▒ ▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░ ");
            Console.WriteLine(" ░ ░  ░░ ░░   ░ ▒░  ░  ▒     ░▒ ░ ▒░▓██ ░▒░ ░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░ ");
            Console.WriteLine("   ░      ░   ░ ░ ░          ░░   ░ ▒ ▒ ░░  ░░         ░         ░     ░░   ░  ");
            Console.WriteLine("   ░  ░         ░ ░ ░         ░     ░ ░                          ░  ░   ░      ");
            Console.WriteLine("                  ░                 ░ ░                                        ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));
            
            for (int i = 0; i < options.Count; i++)
            {
                MenuOption option = options[i];
                if (i == index)
                {

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(option.Title);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(option.Title);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));
        }
    }
}

