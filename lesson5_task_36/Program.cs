
int[] array=new int [10];
int[] GetArrrey (int[] nArrey,int size, int min,int max ){
    for (int i=0;i<size; i++){
        nArrey[i]=new Random().Next(min,max+1);
        Console.Write(nArrey[i]+ " ");
    }
    return nArrey;
};
void NChetArray(int[] nArray){
  int size=nArray.Length ;
  int nChetSum =0;
for (int i=0;i<size;i++){
        if (i%2>0) {nChetSum+=nArray[i];}   
    } 
    Console.WriteLine("Сумма элементов нечетных позиций равна:"+ nChetSum);
}
array=GetArrrey(array,10,1,10);
NChetArray(array);
