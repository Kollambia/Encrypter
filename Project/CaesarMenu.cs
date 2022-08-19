using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс создает меню для шифра Цезаря
    /// </summary>
    public static class CaesarMenu
    {
        /// <summary>
        /// Метод для отображения выбора языковых пунктов для Шифра Цезаря
        /// </summary>
        public static List<MenuOption> options = new List<MenuOption>()
            {
                new MenuOption()
                {
                    Title = "Английский язык",
                    Action = () => MenuHelper.ExecuteMenu(CaesarMenuEng.options),
                },
                new MenuOption()
                {

                    Title = "Русский язык",
                    Action = () => MenuHelper.ExecuteMenu(CaesarMenuRus.options),
                },
                new MenuOption()
                {
                    Title = "Назад",
                    Action = () => MenuHelper.ExecuteMenu(MainMenu.options),
                },
            };
    }
}
