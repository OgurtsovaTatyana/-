// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
int num_len = number.ToString().Length;
 Console.WriteLine(num_len);
//int third_num;
 if (num_len <3) {
  Console.WriteLine("третей цифры в числе нет");  
 }
 else 
 {
    int i=num_len;
    
    while (i>3) {
number=number/10;
i=i-1;
    };
   int third_num=number%10;
    Console.WriteLine("третяя цифра в числа=" + third_num);  
 };
 