﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Console.WriteLine("Введите количнство строк");           // ввод количества строк
//double m = Convert.ToDouble(Console.ReadLine());             // присваивание конвертирование
//Console.WriteLine("Введите количнство столбцов");        // ввод количнства столбцов
//double n = Convert.ToDouble(Console.ReadLine());             // присваивание конвертирование 

void Getarray()                                          // метод
{
double[,] array = new double[10,10];                       // определяем массив
            Random random = new Random();
    for (int i=0; i<10; i++)                                  // цикл по строкам
{
    for (int j= 0; j<10; j++)                              // цикл по столбцам
    {
        array[i,j] = random.NextDouble()*40-20;            // присваиваем рандомное значение
        Console.Write($"{array[i,j]}");                  // сразу печатаем
        Console.Write(" ");                              // пробелы между элементами
    }
Console.WriteLine();                                     // пробелы между строками
}
}

double [,] array = new double[10,10];                             // иниициализация массива
Getarray();                                              // вызов метода


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("Введите координату X элемента массива");       // вводим координату элемента
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y элемента масиива");       // вводим координату элемента
int y = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[x,y];                                        // задаем массив 

int Massiv(int x, int y)                                          // метод до 20 строк и 20 столбцов
{
    int a = 20;                                                   // количетсво строк
    int b = 20;                                                   // количество столбцов
    int[,] array = new int[a,b];                                  // задаем соответствующий массив

    for (int i=0; i<a;i++)                                        // цикл по столбцам 
    {
        for (int j=0; j<b; j++)                                   // цикл по строкам
        {
            array[i,j] = new Random().Next(1,10);                 // рандомно значения элементов
            Console.Write(array[i,j]);                            // сразу печатаем
            Console.Write(" ");                                   // разделяем столбцы
        }
        Console.WriteLine();                                      // разделяем строки
    }
return array[x,y];                                                // возвращаем значение элемента
}

if (x > 20 || y > 20)                                             // задаем условие если координаты x и y больше 20 то 
{
    Console.WriteLine("Такого элемента нет");                     // пишем такого элемента нет
}
else                                                              // иначе   
{
    int c = Massiv(x,y);                                                   // делаем запрос элемента с метода с координатами X и Y
    Console.WriteLine($"Элемент с координатами {x} и {y} равен - {c}");    // вывод на экран
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
void Massive ()                                            // метод генерации массива и подсчета среднего
{
    int a = 10;                                            // Задаем количество строк
    int b = 10;                                            // Задаем количество столбцов
    int[,] array = new int[a,b];                           // Готовим двумерный масиив "int" 
    double [] arr = new double[b];                         // Готовим массив "double" куда будем складывать средние значения по столбцам


    for (int i=0; i<a; i++)                                // Задаем цикл генерации элементов массива - строки
    {
        for (int j=0; j<b; j++)                            // Задаем цикл генерации элементов массива - стоблцы
        {
            array[i,j] = new Random().Next(1,10);          // присваиваем элементу рандомное значение
            Console.Write(array[i,j]);                     // сразу печатаем его на экране
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    Console.Write("Среднее по столбцам массива [");      
    for (int j=0; j<b; j++)                                // Здесь запускаем еще один цикл но теперь дижемся вертикально по столбцам
    {
         for (int i=0; i<a; i++)                           
        {
            arr[j] += array[i,j];                          // Суммируем элементы столбцов         
        }
        arr[j] = arr[j]/b;                                 // Находим среднее
        Console.Write(arr[j]);                             // Сразу выводим на экран
        Console.Write("; ");                               // для удобства чтения ставим точку с запятой между элементами

    }
Console.Write("]");
}
Massive();
*/
