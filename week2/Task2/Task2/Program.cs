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
            string s = Console.ReadLine();
            
            for(int i = 0; i < s.Length/2; i++)
            {
                if(s[i] != s[s.Length - i - 1])
                {
                    Console.WriteLine("NO");
                    Console.ReadKey();
                    Environment.Exit(0);
                  
                } 

            }
            
            Console.WriteLine("YES");
            Console.ReadKey();

        }
    }
}
