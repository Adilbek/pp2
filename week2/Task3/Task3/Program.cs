using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void rec(DirectoryInfo dir, string level) // recursion sozdayu
        {
            Console.WriteLine(level + dir.Name);
            level += "    "; // chtoby stavit/ probely
            FileSystemInfo[] fs = dir.GetFileSystemInfos(); // nahozhdenie file
            for (int i = 0; i < fs.Length; ++i)
            {
                if (fs[i].GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(level + fs[i].Name);
                }
                else
                {
                    rec(fs[i] as DirectoryInfo, level);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\source\repos"); // imya papki
            rec(dir, "");
            Console.ReadKey();
        }
    }
}