// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите 3-х значное число");
int number = int.Parse(Console.ReadLine());
int two_num=number/10;
two_num=two_num%10;
 Console.WriteLine(two_num);