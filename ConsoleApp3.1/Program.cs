using System;

namespace ConsoleApp3._1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random();         
            int sumOfSecondRow = 0;
            int multiplyOfFirstColumn = 1;
            int amountOfColumns = random.Next(4,10);
            int amountOfRows = random.Next(2, 5);
            int startNumbers = 1;
            int endNumbers = 99;

            int[,] array = new int[amountOfRows, amountOfColumns];

            for (int i = 0; i < array.GetLength(0); i++)
            {                
                for (int j = 0; j < array .GetLength(1); j++)
                {
                    array[i, j] = random.Next(startNumbers, endNumbers);

                    Console.Write(array[i, j] + " ");

                    if(i== 1)
                    {
                        sumOfSecondRow += array[i,j];
                    }
                    if(j== 0)
                    {
                        multiplyOfFirstColumn*=array[i,j];
                    }
                }
                Console.WriteLine();                
            }
            Console.WriteLine($"Сумма второго ряда = {sumOfSecondRow}");
            Console.WriteLine($"Произведение первой колонны = {multiplyOfFirstColumn}");
        }
    }
}
