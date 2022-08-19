using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создает главное меню в консоли
    /// </summary>
    public static class MainMenu
    {
        /// <summary>
        /// Создает пункты в главном меню
        /// </summary>
        public static List<MenuOption> options = new List<MenuOption>()
            {
                new MenuOption()
                {
                    Title = "Reverse Cipher",
                    Action = () => MenuHelper.ExecuteMenu(ReverseMenu.options),
                },
                new MenuOption()
                {

                    Title = "Bible Cipher",
                    Action = ()=> MenuHelper.ExecuteMenu(BibleMenu.options),
                },
                new MenuOption()
                {
                    Title = "Morze Cipher",
                    Action = ()=> MenuHelper.ExecuteMenu(MorzeMenu.options),
                },
                new MenuOption()
                {
                    Title = "Caesar Cipher",
                    Action = ()=> MenuHelper.ExecuteMenu(CaesarMenu.options),
                },
                 new MenuOption()
                {
                    Title = "Trans Cipher",
                    Action = ()=> MenuHelper.ExecuteMenu(TransMenu.options),
                },
                 new MenuOption()
                {
                    Title = "Password Generator",
                    Action = GeneratePassword,
                },
                new MenuOption()
                {
                    Title = "Выход",
                    Action = OnExit,
                },
            }; 
        /// <summary>
        /// Метод для отображения пунктов меню для генератора паролей
        /// </summary>
        private static void GeneratePassword()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@" 
██▓███   ▄▄▄        ██████   ██████  █     █░ ▒█████   ██▀███  ▓█████▄    
▓██░  ██▒▒████▄    ▒██    ▒ ▒██    ▒ ▓█░ █ ░█░▒██▒  ██▒▓██ ▒ ██▒▒██▀ ██▌   
▓██░ ██▓▒▒██  ▀█▄  ░ ▓██▄   ░ ▓██▄   ▒█░ █ ░█ ▒██░  ██▒▓██ ░▄█ ▒░██   █▌   
▒██▄█▓▒ ▒░██▄▄▄▄██   ▒   ██▒  ▒   ██▒░█░ █ ░█ ▒██   ██░▒██▀▀█▄  ░▓█▄   ▌   
▒██▒ ░  ░ ▓█   ▓██▒▒██████▒▒▒██████▒▒░░██▒██▓ ░ ████▓▒░░██▓ ▒██▒░▒████▓    
▒▓▒░ ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░░ ▓░▒ ▒  ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░ ▒▒▓  ▒    
░▒ ░       ▒   ▒▒ ░░ ░▒  ░ ░░ ░▒  ░ ░  ▒ ░ ░    ░ ▒ ▒░   ░▒ ░ ▒░ ░ ▒  ▒    
░░         ░   ▒   ░  ░  ░  ░  ░  ░    ░   ░  ░ ░ ░ ▒    ░░   ░  ░ ░  ░    
               ░  ░      ░        ░      ░        ░ ░     ░        ░       
                                                                 ░         ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', Console.WindowWidth));

            PasswordGenerator passwordGenerator = new PasswordGenerator();
            passwordGenerator.NewPasswordMaker();

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
        /// Создает выход из меню
        /// </summary>
        private static void OnExit()
        {
            Environment.Exit(0);
        }
    }
}
