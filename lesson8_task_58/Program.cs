/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
//int[,] a_array = new int[,]{{2, 4},{3,2}};
//int[,] b_array = new int[,]{{3, 4},{3,3}};
int m = 2;
int n = 2;
int[,] a_array = new int[m, n];
int[,] b_array = new int[n, m];
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
int[,] Matrix(int[,] array1, int[,] array2, int m, int n)
{int[,] array3= new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {int sum=0;
            for (int t = 0; t< m; t++) {
         sum=sum+ array1[i, t]*array2[t, j];}
       
        array3[i, j]=sum; 
         

    }
     } return array3;
}

a_array = Get_array(m, n);
b_array = Get_array(n, m);
Print_array(a_array);
Print_array(b_array);
int[,] new_array=Matrix(a_array, b_array, m,n);
Print_array(new_array);
