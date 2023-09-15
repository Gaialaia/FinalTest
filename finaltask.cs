string[] array = new string [] {"lo", "+", "kit", "fun"};
string[] array1 = new string [array.Length];


void NewArr (string [] array, string [] array1) {
     int count = 0;

     for (int i = 0; i < array.Length; i++)  
    {
    if (array[i].Length <= 3 )
    array1[count] = array[i];
   count ++; 
}
 }

Console.WriteLine("Array :");
void PrintArr (string[] array) {
     for (int i = 0; i < array.Length; i++)
  {
       Console.Write($"{array[i],','}");
      

    }
 }

 Console.WriteLine();
NewArr(array,array1);
PrintArr(array1);














