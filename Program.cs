//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Введите количнство строк");           // ввод количества строк
int m = Convert.ToInt32(Console.ReadLine());             // присваивание конвертирование
Console.WriteLine("Введите количнство столбцов");        // ввод количнства столбцов
int n = Convert.ToInt32(Console.ReadLine());             // присваивание конвертирование 

void Getarray()                                          // метод
{
int[,] array = new int[m,n];                             // определяем массив
for (int i=0; i<m; i++)                                  // цикл по строкам
{
    for (int j= 0; j<n; j++)                             // цикл по столбцам
    {
        array[i,j] = new Random().Next(1,10);            // присваиваем рандомное значение
        Console.Write($"{array[i,j]}");                  // сразу печатаем
        Console.Write(" ");                              // пробелы между элементами
    }
Console.WriteLine();                                     // пробелы между строками
}
}

int[,] array = new int[m,n];                             // иниициализация массива
Getarray();                                              // вызов метода
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите координату X элемента массива");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y элемента масиива");
int y = Convert.ToInt32(Console.ReadLine());

void Massiv()
{
    int a = new Random().Next(10,100);
    int b = new Random().Next(10,100);
    int[,] array = new int[a,b];

    for (int i=0; i<a;i++)
    {
        for (int j=0; j<b; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }

}

