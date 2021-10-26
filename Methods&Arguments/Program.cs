


void fillarray(int [] name)
{
      int length=name.Length;
      int index=0;
      while(index<length)
      { 
          name[index]= new Random().Next(1, 100);
          index++;
      }
}

void printarray(int [] print)
{
      int count = print.Length;
      int start = 0;
      while( start<count)
      {
         Console.WriteLine(print[start]); 
         start++;
      }



}

int [] Array = new int[10];

fillarray(Array);
printarray(Array);

//int a1=10; int a2=3; int a3=1;

int Max(int ar1, int ar2, int ar3)
{
    int result = ar1;
    if(result < ar2) result=ar2;
    if(result < ar3) result=ar3;
    return result;
}

int max = Max(
         Max(Array[0],Array[1],Array[2]),
         Max(Array[3],Array[4],Array[5]),
         Max(Array[6],Array[7],Array[8]));
Console.WriteLine("Максимальное число массива =");
Console.WriteLine(max);