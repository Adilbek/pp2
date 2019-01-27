using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{0};
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[n] nums = new int[n];
            for (int i = 2; (i * i) <= n; i++)
            {
                if( n % i == 0)
                {
                    cnt++;
                    numbers.Add(i);
                }
                Console.WriteLine(cnt);
                Console.WriteLine(numbers);
                Console.ReadLine();
            }
        }
    }
}
