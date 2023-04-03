using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве ");
            int rowsCout = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве ");
            int columnsCout = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int[,] array1 = MakeArray(rowsCout, columnsCout);
            int[,] array2 = MakeArray(rowsCout, columnsCout);
            int[,] array3 = new int[rowsCout, columnsCout];

            for (int i = 0; i < rowsCout; i++)
            {
                for (int j = 0; j < columnsCout; j++)
                {
                    array3[i, j] = array1[i, j] + array2[i, j];
                    Console.Write($"{array3[i, j],4}");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

            int[,] MakeArray(int rows, int columns)
            {
                int[,] arr = new int[rowsCout, columnsCout];
                int sum = 0;

                for (int i = 0; i < rowsCout; i++)
                {
                    for (int j = 0; j < columnsCout; j++)
                    {
                        arr[i, j] = rnd.Next(-99, 100);
                        sum += arr[i, j];
                        Console.Write($"{arr[i, j], 4}");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine($"\nСумма элементов: {sum}\n");

                return arr;
            }
        }
    }
}
