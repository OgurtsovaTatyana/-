// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());

int SumN(int num)
{
    int i = 0;
int sum=0;
    while (num>0)
    {
     sum=sum+num%10;
       num=num/10;
    }
    return sum;
}
Console.WriteLine($"  сумма цифр в числе {number} равна:  {SumN(number)}");