using System;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int productOfFirstColumn = 1;
            int sumOfSecondLine = 0;
            int numberOfLine = 1;
            int numberOfColumn = 0;
            int[,] arrayOfNumbers = { { 9, 2, 3, 4, 5, 6, }, { 5, 3, 4, 5, 6, 7 } };

            for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
            {
                sumOfSecondLine += arrayOfNumbers[numberOfLine, j];
            }

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                productOfFirstColumn *= arrayOfNumbers[i, numberOfColumn];
            }

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    Console.Write(arrayOfNumbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма второй строки: {sumOfSecondLine}, Произведение первого столбика: {productOfFirstColumn}\n");
        }
    }
}
