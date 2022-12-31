/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.WriteLine("введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите M");
int m = int.Parse(Console.ReadLine());

int FuncAk(int numN, int numM)
{
    if (numM == 0) { return numN + 1; }
    else
    {
        if (numM > 0 & numN == 0) { return FuncAk(numM - 1, 1); }
        
        else
        {
            if (numM > 0 & numN > 0) return FuncAk(numM - 1, FuncAk(numM, numN - 1));
        }
    }


};
Console.WriteLine(FuncAk(n, m));