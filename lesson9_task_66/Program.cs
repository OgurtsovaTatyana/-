/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("введите N");
int n=int.Parse(Console.ReadLine());
Console.WriteLine("введите M");
int m=int.Parse(Console.ReadLine());

int SumNM(int numN, int numM) {
    if (numN<=numM) {
        return SumNM(numN+1,numM)+numN;
} else return 0;
}
Console.WriteLine(SumNM(n,m));

