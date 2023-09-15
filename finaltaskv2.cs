Console.Write("Enter array size: ");
int elqty = int.Parse(Console.ReadLine());

string[] array = new string [elqty]; 

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\n Enter el {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\n Array :");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.ReadLine();