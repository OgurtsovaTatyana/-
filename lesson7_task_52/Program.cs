/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int m =3;
int n = 4;
int [,] new_array = new int[m, n];
int [,] Get_array(int m, int n)
{
    int[,] array =new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}
void Print_array (int[,] array){
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}
void Search_average (int[,] array, int m,int n){
int aver;
for (int j = 0; j < n; j++)
{aver=0;
    for (int i = 0; i < m; i++)
    {
        aver=aver+array[i, j];
    }
    double sum = Math.Round(Convert.ToDouble(aver)/Convert.ToDouble(m),1);
    Console.Write( sum + " ");
}

}

new_array=Get_array(m, n);
Print_array(new_array);
Search_average (new_array, m, n);
