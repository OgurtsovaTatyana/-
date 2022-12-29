/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)
Console.WriteLine("введите количество строк");*/
Console.WriteLine("введите номер строки");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int columns = int.Parse(Console.ReadLine());
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
void Search_index (int[,] array, int row,int col){
if (row<=m & col<=n) {
    Console.WriteLine($"элемент с индексами [{row},{col}] равен:{array[row, col]}  ");
}
else { Console.WriteLine($"элемента с индексами [{row},{col}] нет  ");}
}

new_array=Get_array(m, n);
Print_array(new_array);
Search_index (new_array, rows,columns);