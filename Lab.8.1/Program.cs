using System;
using System.IO;

namespace Lab._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Виктория/Desktop/Маша";
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] directoryArr = directory.GetDirectories();
            Console.WriteLine("Список подкаталогов в каталоге");
            foreach (DirectoryInfo d in directoryArr)
            {
                Console.WriteLine(d.Name);
                FileInfo[] dArr = d.GetFiles();
                Console.WriteLine("Список файлов в подкаталоге");
                foreach (FileInfo c in dArr)
                {
                    Console.WriteLine(c.Name);

                }
                Console.WriteLine("Список подкаталогов в подкаталоге");
                DirectoryInfo[] d1Arr = d.GetDirectories();
                foreach (DirectoryInfo b in d1Arr)
                {
                    Console.WriteLine(b.Name);

                }

            }
            FileInfo[] dirArr = directory.GetFiles();
            Console.WriteLine("Список файлов в каталоге");
            foreach (FileInfo n in dirArr)
            {
                Console.WriteLine(n.Name);

            }
            Console.ReadKey();

        }

        
    }
}
