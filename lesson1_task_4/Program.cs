﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a>b & a>c)
{Console.WriteLine(a);};
 if (b>a & b>c) 
 {Console.WriteLine(b);};
 if (c>a & c>b) 
 {Console.WriteLine(c);};