/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int m = 2;
int n = 2;
int k=2;
int[,,] a_array = new int[m, n,k];
Random rnd = new Random();

int[,,] Get_array(int m, int n,int l)
{
    int[,,] array = new int[m, n,l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           for (int p = 0; p < k; p++)
        { array[i, j,p] = rnd.Next(0, 100);
        }
        }
    }
    return array;
}

void Print_array(int[,,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int p = 0; p < k; p++){
            Console.Write($"{array[i, j,p]} ({i},{j},{p}) ");
        } Console.WriteLine();
        }
    }
     Console.WriteLine();
}

a_array = Get_array(m, n,k);
Print_array(a_array);
