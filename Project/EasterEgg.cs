using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// класс создающий Пасхалку
    /// </summary>
    public class EasterEgg
    {
       /// <summary>
       /// Метод задействующий пианино
       /// </summary>
        public void Piano()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Позравляем, Вы нашли пасхалку! Начните играть мелодию. Вашими клавишами будут цифры от 1 до 8!");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Если закончили играть, то нажмите (Пробел), чтобы вернуться в меню");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.D1)
                {
                    Console.Beep(262, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    Console.Beep(294, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D3)
                {
                    Console.Beep(330, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D4)
                {
                    Console.Beep(350, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D5)
                {
                    Console.Beep(397, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D6)
                {
                    Console.Beep(445, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D7)
                {
                    Console.Beep(500, 450);
                }
                else if (keyInfo.Key == ConsoleKey.D8)
                {
                    Console.Beep(530, 450);
                }
                
            } while (keyInfo.Key != ConsoleKey.Spacebar);
        }
    }   
}
