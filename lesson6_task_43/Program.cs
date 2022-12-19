// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите параметры уравнений (через пробел): b1, k1, b2 ,k2");
string[] sArray = (Console.ReadLine()).Split(' ');
double[] nArray = new double[sArray.Length];
int i = 0;
foreach (string elem in sArray)
{
    nArray[i] = double.Parse(elem);
    i++;
}
if (nArray[1] == nArray[3]) 
    { Console.WriteLine("точек пересечения нет"); }
else
{
    double x = (nArray[0] - nArray[2]) / (nArray[3] - nArray[1]);//x=(b1-b2)/(k2-k1)
    double y = (nArray[1] * (nArray[2] - nArray[0])) / (nArray[3] - nArray[1]) + nArray[0]; //(y=k1*(b1-b2)/(k2-k1)+b1
    Console.WriteLine($"коордитаны точки пересечения прямых y={nArray[1]}*x + {nArray[0]} и y={nArray[3]}*x + {nArray[2]} равны {x},{y}");
}

 //Вариант2
 /*Console.WriteLine("введите параметры уравнений (через enter): b1, k1, b2 ,k2");
 double b1= double.Parse(Console.ReadLine());
double k1= double.Parse(Console.ReadLine());
double b2= double.Parse(Console.ReadLine());
double k2= double.Parse(Console.ReadLine());

void FindDot ( double b1,  double k1, double b2 , double k2){
if (k1==k2) 
    { Console.WriteLine("точек пересечения нет");}
else
{
    double x=(b1-b2)/(k2-k1);
    double y=b1+(k1*(b1-b2))/(k2-k1);
    Console.WriteLine($"коордитаны точки пересечения прямых y={k1}*x + {b1} и y={k2}*x + {b2} равны {x},{y}");
}
}
FindDot(b1, k1, b2 ,k2);
*/