/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
    Console.WriteLine();
}
int[,] Sorting(int[,] array, int m, int n)
{

    for (int i = 0; i < m; i++)
    { for (int t = n-1; t>0; t=t-1){
        for (int j = 0; j <t; j++)
        {
            if (array[i, j] > array[i, j +1])
            {
                int elem = array[i, j];
                array[i, j] = array[i, j +1];
                array[i, j + 1] = elem;
            
            }
        }
        }
    }
    return array;
}

new_array = Get_array(m, n);
Print_array(new_array);
int[,] arraySort = Sorting(new_array, m, n);
Print_array(arraySort);
