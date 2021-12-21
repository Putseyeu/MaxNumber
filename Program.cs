using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA = new int[10, 10];
            Random random = new Random();
            int maxNumber = 0;
            int rowNumber = 0;
            int columnNumber = 0;
            int newNumber = 0;
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayA[i, j] = random.Next(100, 999);
                    Console.Write(arrayA[i, j] + " ");
                }
                Console.WriteLine();                
            }
            
            for (int i = 0;i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    if (arrayA[i, j] > maxNumber)
                    {
                        maxNumber = arrayA[i, j];
                        rowNumber = i;
                        columnNumber = j;
                    }
                }
            }

            Console.WriteLine($"наибольший элемент = {arrayA[rowNumber, columnNumber]}");
            Console.WriteLine("Полученная матрица:");
            arrayA[rowNumber, columnNumber] = newNumber;
            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {                    
                    Console.Write(arrayA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
