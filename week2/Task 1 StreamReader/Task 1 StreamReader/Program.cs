using System;
using System.IO;
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
            StreamReader sr = new StreamReader("../../input.txt");
            string s = sr.ReadToEnd(); // sozdaem stroku i vvodim s klaviatury
            sr.Close();
            StreamWriter sw = new StreamWriter("../../output.txt");
            for (int i = 0; i < s.Length / 2; i++) // ciklom probegaemsya do poloviny razmera stroki
            {
                if (s[i] != s[s.Length - i - 1]) // esli [i] ne sozpadaet s length - i - 1 cout No
                {
                    sw.Write("NO"); // delim stroku na dve chasti i proveryam sovpadaet li pervyi element s poslednim; vtoroi s predposl, i tak dalee


                    Environment.Exit(0);

                }

            }

            sw.Write("YES");


        }
    }
}
