using System;
using System.IO;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../input.txt");
            String s = sr.ReadToEnd();
            String[] str = s.Split(); //schital i zapisal na massiv str
            sr.Close();

            List<int> arr = new List<int>();
            List<int> Prime = new List<int>();  // sozdal list chtoby hranit/ prostyh chisel i 

            foreach (string a in str)
            {
                arr.Add(int.Parse(a));
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (IsPrime(arr[i]) == 1) // peredal chisla iz massiva v method IsPrime 
                {
                    Prime.Add(arr[i]); // esli method raven odnomu to kidaem v list Prime
                }
            }

            StreamWriter sw = new StreamWriter("../../output.txt");
            if (Prime.Count >= 1)  // esli v liste est' hot' odno prostoe chislo
            {
                for (int i = 0; i < Prime.Count; i++)
                {
                    sw.Write(Prime[i] + " "); // to vyvodil vse prostye chisla
                }
            }
            else sw.Write("No"); // else vyvodil no
            sw.Close();

        }

        public static int IsPrime(int num)
        {
            for (int i = 2; i <= num; i++) // perebiraem ot 2 do chisla kotorogo my peredali
            {
                if ((i == num) || (i > Math.Sqrt(num))) // proveryaem esli i ravno num return 1   
                {                                       
                    return 1;                           
                }
                if (num % i == 0 && i != num || num == 1)  // 1 ne prostoe chislo
                {
                    return 0;                           // esli i ne ravno num isklyuchaem ih iz lista
                }
            }
            return 0;
        }
    }
}

