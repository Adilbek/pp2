using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // sozdaem stroku i vvodim s klaviatury

            for (int i = 0; i < s.Length / 2; i++) // ciklom probegaemsya do poloviny razmera stroki
            {
                if (s[i] != s[s.Length - i - 1]) // esli [i] ne sozpadaet s length - i - 1 cout No
                {
                    Console.WriteLine("NO"); // delim stroku na dve chasti i proveryam sovpadaet li pervyi element s poslednim; vtoroi s predposl, i tak dalee
                                  
                    Console.ReadKey();
                    Environment.Exit(0);

                }

            }

            Console.WriteLine("YES");
            Console.ReadKey();

        }
    }
}