using System;
string [] arr={" drawio","it","ell", "reused", "git","!!!"};
string [] arr2 =new string[0]; 
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i].Length <= 3)
    {
        count++;
        Array.Resize(ref arr2,count);
        arr2[count-1] =arr[i];
        
    }
   
}
System.Console.WriteLine();
 for (int i = 0; i <arr2.Length ; i++)
    {
        System.Console.Write(arr2[i] + " "); 
    }

