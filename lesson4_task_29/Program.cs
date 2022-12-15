//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int n=8;
int[] arrayN = new int[n];

void GetArray (int[] array, int n) {
for (int i=0;i<n;i++){
    array [i]=new Random().Next(1,10);
//Console.WriteLine($"{i} = {array [i]}");
}
};

GetArray(arrayN,n);

Console.WriteLine(string.Join(" ",arrayN));