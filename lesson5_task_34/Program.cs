// See https://aka.ms/new-console-template for more information
int[] array=new int [10];
int[] GetArrrey (int[] nArrey,int size, int min,int max ){
    for (int i=0;i<size; i++){
        nArrey[i]=new Random().Next(min,max+1);
        Console.Write(nArrey[i]+ " ");
    }
    return nArrey;
};


void ChetArray(int[] nArray){
   int count =0;
foreach (int elem in nArray){
        if (elem%2==0) {count++;}
       
    } 
    Console.WriteLine("количество четных чисел равно:"+ count);
}
array=GetArrrey(array,10,100,1000);
ChetArray(array);
