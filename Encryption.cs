using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8th_Theory
{
    internal class Encryption
    {
        public static string Encrypt(string plainText, int shift)
        {
            int l = plainText.Length;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string final = "";
            int letter = 0;

            for (int i = 0; i < l; i++)
            {
                for (int x = 0; x < 25; x++)
                {
                    if (plainText[i] == alphabet[x])
                    {
                        letter = x;
                    }


                }
                final = final + alphabet[(letter + shift) % 25];
            }
            return final;
        }
        public static string Decrypt(string plainText, int shift)
        {
            int l = plainText.Length;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string final = "";
            int letter = 0;

            for (int i = 0; i < l; i++)
            {
                for (int x = 0; x < 25; x++)
                {
                    if (plainText[i] == alphabet[x])
                    {
                        letter = x;
                    }


                }
                final = final + alphabet[(letter - shift) % 25];
            }
            return final;
        }
    }
}
