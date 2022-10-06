using System;
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
            RLE();
        }
        static void RLE()
        {
            Console.WriteLine("Enter the string to be compressed");
            string compress = Console.ReadLine();
            int count = 0;
            string final = "";
            for (int i = 0; i < compress.Length; i++)
            {
                    for (int x = 0; x < compress.Length; x++)
                {
                    if (compress[x] == compress[i])
                    {
                        count++;
                    }
                    else if (compress[x] != compress[i])
                    {
                        final = final + compress[i] + count;
                        
                        
                    }
                  
                    
                }
                   




            }
            Console.WriteLine(final);
        }
    }
}
