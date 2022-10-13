using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace L8th_Theory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RLE();
            
            byte[] final = Encryption.VernamE("hello");
            Console.WriteLine(string.Join(", ", final));

        }
        static void RLE()
        {
            Console.WriteLine("Enter the string to be compressed");
            string compress = Console.ReadLine();
            int count = 0;
            string final = "";
            for (int i = 0; i < compress.Length; i++)
            {
                //    for (int x = 0; x < compress.Length; x++)
                //{
                //    if (compress[x] == compress[i] )
                //    {
                //        count++;
                //    }
                //    else if (compress[x] != compress[i])
                //    {
                //        final = final + compress[i] + count;


                //    }



                if (i == 0 || compress[i] == compress[i - 1])
                {
                    count++;
                    if (i == (compress.Length - 1) || compress[i] != compress[i + 1])
                    {
                        final = final + compress[i] + count;
                        count = 0;
                    }

                }
            }




            
            Console.WriteLine(final);
        }
    }
}
