using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания шифра из Азбуки Морзе
    /// </summary>
    public class MorzeCipher
    {
        string[] morzRus = { ".-", "-...", ".--", "--.", "-..", ".", ".", "...-", "--..", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", ".-.", "...", "-", "..-", "..-.", "....", "-.-.", "---.", "----", "--.-", "--.--", "-.--", "-..-", "..-..", "..--", ".-.-", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };
        string AlphRus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя1234567890";

        string[] morzEng = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-.--", "-..-", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };
        string AlphEng = "abcdefghijklmnopqrstuvwxyz1234567890";

        /// <summary>
        /// Метод, шифрующий сообщение на руссом языке в Азбуку Морзе
        /// </summary>
        public void MorzRus(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < AlphRus.Length; j++)
                {
                    if (AlphRus[j] == input[i])
                    {
                        Console.Write(morzRus[j] + " ");
                        MorzSong(morzRus[j]);
                    }
                }
            }
        }
        /// <summary>
        /// Метод, шифрующий сообщение на английском языке в Азбуку Морзе
        /// </summary>
        public void MorzEng(string input)
        {
            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {           
                for (int j = 0; j < AlphEng.Length; j++)
                {
                    if (AlphEng[j] == input[i])
                    {
                        Console.Write(morzEng[j] + " ");
                        MorzSong(morzEng[j]);
                    }
                }
            }
        }
        /// <summary>
        /// Метод для создания звукового сопровождения зашифрованного сообщения
        /// </summary>
        static void MorzSong(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    Console.Beep(900, 500);
                }

                else
                {
                    Console.Beep(900, 1100);
                }
            }
            Thread.Sleep(1000);
        }
    }
}


