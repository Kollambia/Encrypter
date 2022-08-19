using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс создающий Шифр Цезаря
    /// </summary>
    public class CaesarCipher

    {
        string ruAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string engAlphabet = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Метод, позволяющий зашифровать сообщение на русском языке
        /// </summary>
        public void EncrypRU(string message, int key)
        {
            message = message.ToLower();
            string emptyString = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                char words = message[i];

                int indexes = ruAlphabet.IndexOf(words);
                if (indexes < 0)
                {
                    emptyString += words.ToString();
                }
                else
                {
                    int codeIndex1 = (ruAlphabet.Length + indexes + key) % 33;
                    emptyString += ruAlphabet[codeIndex1];
                }

            }
            Console.WriteLine(emptyString);
        }
        /// <summary>
        /// Метод, позволяющий расшифровать сообщение на русском языке
        /// </summary>
        public void DecrypRU(string message, int key)
        {
            message = message.ToLower();
            string emptyString = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                char words = message[i];

                int indexes = ruAlphabet.IndexOf(words);
                if (indexes < 0)
                {
                    emptyString += words.ToString();
                }
                else
                {
                    int codeIndex2 = (ruAlphabet.Length + indexes - key) % 33;
                    emptyString += ruAlphabet[codeIndex2];
                }

            }
            Console.WriteLine(emptyString);
        }
        /// <summary>
        /// Метод, позволяющий зашифровать сообщение на английском языке
        /// </summary>
        public void EncrypEng(string message, int key)
        {
            message = message.ToLower();
            string emptyString = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                char words = message[i];

                int indexes = engAlphabet.IndexOf(words);

                if (indexes < 0)
                {
                    emptyString += words.ToString();
                }
                else
                {
                    int codeIndex1 = (engAlphabet.Length + indexes + key) % 26;
                    emptyString += engAlphabet[codeIndex1];
                }

            }
            Console.WriteLine(emptyString);
        }
        /// <summary>
        /// Метод, позволяющий расшифровать сообщение на английском языке
        /// </summary>
        public void DecrypEng(string message, int key)
        {
            message = message.ToLower();
            string emptyString = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                char words = message[i];

                int indexes = engAlphabet.IndexOf(words);

                if (indexes < 0)
                {
                    emptyString += words.ToString();
                }
                else
                {
                    int codeIndex2 = (engAlphabet.Length + indexes - key) % 26;
                    emptyString += engAlphabet[codeIndex2];
                }
                
            }
            Console.WriteLine(emptyString);
        }
    }
}

