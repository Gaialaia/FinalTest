﻿string[] array = new string [6] {"lotus", "+", "kitty", "square", "recepie", "fun"};
string[] array1 = new string [array.Length];

void NewArr (string [] array, string [] array1) {
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= 3)
    array1[count] = array[i];
    count ++; 
}
}


