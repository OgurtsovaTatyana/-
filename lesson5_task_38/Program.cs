double[] array=new double[10];
double[] GetArrrey (double[] nArrey,int size){
    for (int i=0;i<size; i++){
        nArrey[i]=Math.Round((new Random().NextDouble())*100);
        Console.Write(nArrey[i]+ " ");
    }
    return nArrey;
};
void Max_minArray(double[] nArray){
 int size=nArray.Length ;
  double max =nArray[0];
  double min =nArray[0];
foreach (int elem in nArray){
   if (elem>max) {max=elem;}   
    if (elem< min) {min=elem;}   
   } 
   Console.WriteLine("min= "+ min +"  max= "+max);
}
array=GetArrrey(array,10);
Max_minArray(array);
