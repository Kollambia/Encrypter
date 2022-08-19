using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания зашифрованного сообщения по Библейскому шифру
    /// </summary>
    public class BibleCipher
    {
        string abc = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя ";
        string reverseAbc = "zyxwvutsrqponmlkjihgfedcbaяюэьыъщшчцхфутсрпонмлкйизжёедгвба ";

        /// <summary>
        /// Метод, зашифровывающий и расшировывающий сообщение по Библейскому шифру
        /// </summary>
        public void EncryptDecrypt(string text)
        {
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (text[i] == abc[j])
                    {
                        Console.Write(reverseAbc[j]);
                    }
                }
            }
        }
    }
}

