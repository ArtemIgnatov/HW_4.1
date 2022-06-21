using System;
namespace HW_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int str = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов матрицы: ");
            int clm = int.Parse(Console.ReadLine());

            int[,] a = new int[str, clm]; //Создаем матрицу, согласно указанным значениям

            Random r = new Random();
            int sum = 0; //Определяем переменную, в коорую будем суммировать все элементы матрицы

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < clm; j++)
                {
                    a[i,j] = (int)r.Next(1,100); //Заполняем тело матрицы
                    Console.Write($"{a[i,j],2} "); //Выводим элемент матрицы на экран
                    sum += a[i,j]; //Суммируем элемент матрицы
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех элементов матрицы равна: {sum}");
            //Выводим сумму всех элементов матрицы на экран
            Console.ReadKey();
        }
    }
}
