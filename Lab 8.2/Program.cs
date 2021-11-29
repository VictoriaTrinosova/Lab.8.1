using System;
using System.IO;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Виктория/Desktop/Bim проектирование/Lab.8.1/Числа.txt";
            using (StreamWriter sw = new StreamWriter(path, true)) 
            { 
            int[] array = new int[10];
            Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 20);
                    sw.WriteLine("{0}", array[i]);
                   
                }
                Console.WriteLine();
            }
            using (StreamReader sr = new StreamReader(path))
            {
                int s = 0;
                for (int i=0;i<10;i++)
                {
                   int x = Convert.ToInt32(sr.ReadLine());
                    s += x;
                    Console.WriteLine(x);
                }
                Console.WriteLine("Сумма чисел равна={0}",s);
            }
            Console.ReadKey();
        }
    }
}
