using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Класс для создания Транс Шифра
    /// </summary>
    public class TransCipher
    {
        string keyboard1 = "qwertyuiop[]asdfghjkl;'zxcvbnm,.`йцукенгшщзхъфывапролджэячсмитьбюё ";
        string keyboard2 = "йцукенгшщзхъфывапролджэячсмитьбюёqwertyuiop[]asdfghjkl;'zxcvbnm,.` ";

        /// <summary>
        /// Метод отвечающий одновременно и за шифрование, и за расшифрование
        /// </summary>
        public void EncrypDecryp(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {

                for (int j = 0; j < keyboard1.Length; j++)
                {
                    if (keyboard1[j] == input[i])
                    {
                        Console.Write(keyboard2[j]);
                    }
                }
            }
        }
    }
}
