using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split();
            for ( int i = 0; i< arr.GetLength(0); i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            

        } 
    }
}
