using System;

namespace NewC_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthArray = 6;
            int heightArray = 6;
            int searchString = 2;
            int searchColumn = 1;
            int productNumbersColumn = 1;
            int sumNumbersString = 0;
            int minRandomNumbers = 1;
            int maxRandomNumbers = 100;

            int[,] numbers = new int[lengthArray, heightArray];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minRandomNumbers,maxRandomNumbers);
                    Console.Write($"{numbers[i, j]} ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(1); i++)
                sumNumbersString += numbers[searchString - 1, i];

            for (int i = 0; i < numbers.GetLength(0); i++)
                productNumbersColumn *= numbers[i, searchColumn - 1];


            Console.WriteLine($"Сумма чисет в {searchString} строке = {sumNumbersString}; Произведение чисев в {searchColumn} столбце = {productNumbersColumn}.");
            Console.ReadKey();
        }
    }
}