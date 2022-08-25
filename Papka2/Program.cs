/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;

Clear();

Write("Введите искомую строку: ");
int pos1 = Convert.ToInt32(ReadLine()) - 1;

Write("Введите искомый столбец: ");
int pos2 = Convert.ToInt32(ReadLine()) - 1;

int n = 5; int m = 7;
int[,] arr = new int[n, m];

WriteLine("Исходный массив: ");

void FillArray(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 99);
            Write("{0} ", arr[i, j]);
        }
        WriteLine();
    }
}
// Поиск числа в заданной строке и колонке
void FindNumber(int n, int m)
{
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 |
        pos2 < 0 | pos2 > arr.GetLength(1) - 1)
    {
        WriteLine("Элемент не существует  ");
    }
    else
    {
        WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
    }
}

FillArray(arr);
FindNumber(n, m);
