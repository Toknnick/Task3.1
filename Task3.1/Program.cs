using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue = 9;
            int minValue = 1;
            int numberOfLines = random.Next(minValue, maxValue); ;
            int numberOfColumns = random.Next(minValue, maxValue);
            int productOfFirstColumn = 1; 
            int sumOfSecondLine = 0;
            int[,] arrayOfNumbers = new int[numberOfLines, numberOfColumns];
            Console.WriteLine($"Строк: {numberOfLines} столбов: {numberOfColumns}");
            int numberMinArray = 10;
            int numberMaxArray = 99;
            Console.WriteLine("\nМассив:");

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {

                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    arrayOfNumbers[i, j] = random.Next(numberMinArray, numberMaxArray);
                    Console.Write(arrayOfNumbers[i, j] + " ");

                    if (i == 1)
                    {
                        sumOfSecondLine += arrayOfNumbers[i, j];
                    }

                    if (j == 0)
                    {
                        productOfFirstColumn *= arrayOfNumbers[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма второй строки: {sumOfSecondLine}, Произведение первого столбика: {productOfFirstColumn}\n");
        }
    }
}
