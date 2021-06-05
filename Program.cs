using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 10];
            Random random = new Random();
            int min = myArray[0, 0];
            int max = myArray[0, 0];
            int diag_sum = 0;
            int diff = 0;
            int sum = 0;

            //Заполнение двумерного случайными числами
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = random.Next(-100, 100);
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("\n");

            //Поиск наименьшего числа
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    if (myArray[y, x] < min)
                        min = myArray[y, x];
                }
            }
            Console.WriteLine("Наименьшее число двумерного массива: " + min);
            
            //Поиск наибольшего числа
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    if (myArray[y, x] > max)
                        max = myArray[y, x];
                }
            }
            Console.WriteLine("Наибольшее число двумерного массива: " + max + "\n");
           
            //Вывод суммы чисел по диагонали
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                diag_sum += myArray[y, y]; 
            }
            Console.WriteLine("Сумма чисел по диагонали: " + diag_sum);
            Console.Write("\n");
            
            //Сумма отрицательных четных чисел
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    if (myArray[y, x] % 2 == 0 && myArray[y,x] < 0)
                    sum += myArray[y, x];
                }
            }   
            Console.WriteLine("Сумма отрицательных четных чисел: " + sum + "\n");
            
            //Количество положительных четных чисел
            foreach (int y in myArray)
            {
                if ((y % 2) != 0 && y > 0) diff++;
            }
            Console.WriteLine("Количество положительных нечетных чисел: {0}", diff, myArray.Length - diff);
        }
    }
}


    
