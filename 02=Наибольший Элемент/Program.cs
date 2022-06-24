using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Наибольший_Элемент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;
            int arrayHeight = 10;
            int[,] array = new int[arrayLength, arrayHeight];
            Random random = new Random();
            int maximumNumber = 10;
            int minimumNumber = 1;
            int largestNumber = 0;
            int replacingNumber = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minimumNumber, maximumNumber);                    

                    if (largestNumber < array[i, j])
                    {
                        largestNumber = array[i, j];                        
                    }
                    Console.Write(array[i, j] + " ");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМаксимальное число в матрице: " + largestNumber + "\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] == largestNumber)
                    {
                        array[i, j] = replacingNumber;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
