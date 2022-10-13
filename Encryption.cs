using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L8th_Theory
{
    internal class Encryption
    {
        public static Byte[] OneTimePad(int l)
        {
            Random rnd = new Random();
            byte[] b = new byte[l];
            rnd.NextBytes(b);
            return b;
        }
        public static string Encrypt(string plainText, int shift)
        {
            int l = plainText.Length;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string final = "";
            int letter = 0;

            for (int i = 0; i< l; i++)
            {
                for(int x = 0; x < 25; x++)
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
                int finalN = letter - shift;
                if (finalN < 0)
                {
                    finalN = finalN + 26;
                }
                final = final + alphabet[finalN];
            }
            return final;
        }
        public static byte[] VernamE(string plainText)
        {
            byte[] str = Encoding.ASCII.GetBytes(plainText);
            int l = plainText.Length;
            byte[] arr = OneTimePad(l);
            byte[] final = new byte[l];
            for (int i = 0; i<l; i++)
            {
                final[i] = (byte)(arr[i] ^ str[i]);
            }
            return final;
                
        }
}}
