// See https://aka.ms/new-console-template for more information
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = int.Parse(Console.ReadLine());
double[,] new_array = new double[m, n];
double[,] Get_array(int n, int m)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
        }
    }
    return array;
}
void Print_array ( double[,] array){
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}

new_array=Get_array( n, m);
Print_array(new_array);
