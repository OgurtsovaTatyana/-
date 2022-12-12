// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите день недели: число от 1 до 7");
int number = int.Parse(Console.ReadLine());
if (number > 7 | number < 1)
{
    Console.WriteLine("неверно введено число");
}
else
{
    if (number > 5)
    {
        Console.WriteLine(number + " день - выходной :)))");
    }
    else
    {
        Console.WriteLine(number + " день - рабочий :(");
    };

};