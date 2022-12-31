/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.WriteLine("введите N");
int n=int.Parse(Console.ReadLine());
string NumbersWrite (int num) {
    if (num>1) {
        return NumbersWrite(num-1)+$"{num}";
} else return "1";
}
Console.WriteLine(NumbersWrite(n));

