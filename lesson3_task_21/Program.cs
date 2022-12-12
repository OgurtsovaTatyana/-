// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите координаты точки А: x,y,z");
int Ax = int.Parse(Console.ReadLine());
int Ay = int.Parse(Console.ReadLine());
int Az = int.Parse(Console.ReadLine());
Console.WriteLine("введите координаты точки B: x,y,z");
int Bx = int.Parse(Console.ReadLine());
int By = int.Parse(Console.ReadLine());
int Bz = int.Parse(Console.ReadLine());
double res=Math.Sqrt((Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)+(Bz-Az)*(Bz-Az));
Console.WriteLine("Расстояние между точками равно: " + res);