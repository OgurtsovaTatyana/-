// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите 5-значное число");
int number = int.Parse(Console.ReadLine());
int num_5=number%10;
number=number/10;
int num_4=number%10;
number=number/10;
int num_3=number%10;
number=number/10;
int num_2=number%10;
int num_1=number/10;
 Console.WriteLine(num_1 + " " + num_2 + " " + num_3 + " " + num_4 + " " + num_5);
 if (num_1 == num_5 & num_2 == num_4 ) {
    Console.WriteLine("заданное число полиндром");
 }
 else {
     Console.WriteLine("заданное число не полиндром");
 }
