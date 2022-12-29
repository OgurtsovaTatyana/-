/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int m = 3;
int n = 4;
int[,] new_array = new int[m, n];
int[,] Get_array(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void Print_array(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Min_sum(int[,] array, int m, int n)
{
    int sum = 0;
    int index = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + array[0, j];
    };
    int minSum = sum;
    for (int i = 1; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + array[i, j];
        }
        
        if (minSum>sum)
        {
            minSum = sum;
            index = i;
        }

    }
    Console.WriteLine(minSum + " минимальная сумма в строке:" + index);
}

new_array = Get_array(m, n);
Print_array(new_array);
Min_sum(new_array, m, n);

