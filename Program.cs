﻿//ДЗ:
//Запрашивать у пользователя числа до тех пор пока пользователь не введёт букву Q
//Числа добавляются в массив, в случае переполнения массива (кончилось начальное количество элементов) массив необходимо расширить
//(сохранив все введённые до этого значения) и продолжить записывать данные пользователя
//После ввода буквы Q вывести на экран все введённые данные пользователем

//В случае если пользователь ввёл данные не верно, программа не должна прекращать своё выполнение,
//а должна вывести информацию на экран и продолжить запрашивать данные от пользователя

//Запросить что он хочет делать:
//Очистить
//Продолжить
//Выйти

//В случае Продолжить: продолжаем принимать данные от пользователя
//В случае Очистить: Очищаем массив данных и снова спрашиваем у пользователя, что он хочет делать дальше
//В случае Выйти: Завершаем программу, с выводом информации о том сколько пользователь ввёл элементов (количество) и количество совершённых им ошибок

namespace Lesson_3_1
{
    internal class Program
    {
        static void Main(string[] args)

        
        {
            // Объявляем массив и начальные значения переменных количества элементов и ошибок
            int[] array = new int[1];
            int count = 0;
            int errors = 0;

            //цикл
            while (true)
            {
            
                Console.WriteLine("Введите число для записи в массив или символ Q для вызова меню:");
                int symbol = Convert.ToInt32(Console.ReadLine());

                if (symbol == "q" || symbol == "Q")
                {
                    Console.WriteLine("Содержимое массива:");
                    Console.WriteLine(array[i]);
                }
                else
                {
                }

                array[i] = symbol;    
                
                









            }



            
        }
    }
}
