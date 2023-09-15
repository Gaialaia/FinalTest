
Console.Write("Enter array size: ");
int elqty = int.Parse(Console.ReadLine());

string[] array = new string [elqty]; 
string[] array1 = new string [array.Length];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\n Enter el of index {i}:\t");
    array[i] = Console.ReadLine();
    
}
Console.WriteLine("\n Array :");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.ReadLine();



void ShortArr (string [] array, string [] array1) {
     int count = 0;

     for (int i = 0; i < array.Length; i++)  
    {
    if (array[i].Length <= 3 )
    array1[count] = array[i];
   count ++; 
}
 }

Console.WriteLine("Array >= 3 :");
void PrintArr (string[] array) {
     for (int i = 0; i < array.Length; i++)
  {
             Console.WriteLine(array[i]);    
    }
 }

ShortArr(array,array1);
PrintArr(array1);