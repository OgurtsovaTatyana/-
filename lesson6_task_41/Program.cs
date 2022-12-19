// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите элементы массива через пробел");
string[] sArray = (Console.ReadLine()).Split(' ');
int size = sArray.Length;
int[] nArray = new int[size];
int[] GetArray(string[] array)
{
    int i = 0;
    int[] newArray = new int[size];
    foreach (string elem in array)
    {
        newArray[i] = int.Parse(elem);
        i++;
    }
   // Console.WriteLine("massiv " + string.Join(" ", newArray));
    return newArray;
    
};

void CheckArray(int[] array)
{
    int count = 0;
    foreach (int elem in array)
    {
        if (elem > 0) count++;
    };
    Console.WriteLine("Количество положительных чисел: " + count);
};
nArray = GetArray(sArray);
CheckArray(nArray);