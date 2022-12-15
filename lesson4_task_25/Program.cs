// Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = int.Parse(Console.ReadLine());
int Step (int num1,int num2){
int i=1;
int  step=1;
while (i<=num2) {
    step=step*num1;
    i++;
}
  return step;   
}
Console.WriteLine($" {numberB}-ая степень числа {numberA} равна  {Step(numberA,numberB)}");