/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
int m = 4;
int n = 4;

int[,] arrayS = new int[m, n];


int[,] Get_array(int m, int n)
{
    int[,] array = new int[m, n];
           
  

    return array;
}

void Print_array(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        
        {
            Console.Write($"{array[i, j]}  ");
        } Console.WriteLine();
        
    }
     Console.WriteLine();
}

arrayS = Get_array(m, n);
Print_array(arrayS);
