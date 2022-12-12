// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
int i=1;
 Console.Write(number + " --> ");
while (i<=number) {
    Console.Write(Math.Pow(i,3)+ " ");
    i++;
}
    
