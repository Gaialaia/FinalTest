﻿string[] array = new string [4] {"lo", "+", "kit", "fun"};
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


void PrintArr (string[] array) {
     for (int i = 0; i < array.Length; i++)
  {
       Console.Write($"{array[i],','}");
      

    }
 }

 Console.WriteLine();
NewArr(array,array1);
PrintArr(array1);

// string[] M;
// Console.WriteLine("Введите массив строк через запятую");
// string stroka = Console.ReadLine();
// M = stroka.Split(',');
// var result = new string[M .Length];
// var realSize = 0;
// foreach (var value in M )
// {
//     if (value.Length <= 3)
//     {
//         result[realSize] = value;
//         realSize++;
//     }
// }
// Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
// Console.ReadKey(true);












