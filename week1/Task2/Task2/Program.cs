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
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            string[] s = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            int it = 0;
            List<int> r = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                r.Add(arr[i]);

                r.Add(arr[i]);
            }
            for (int i = 0; i < r.Count ; ++i)
            {
                Console.Write(r[i] + ' ');
            }
            Console.ReadKey();
        }

        static void ma(int[] d, int n)
        {
            
        }
    }
    
}