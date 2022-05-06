﻿// формирование результирующего массива строк, длина которых меньше либо равна lim символов
string[] GetFormedArray(string[] array, int lim)
{
    int len = array.Length, k = 0;
    int[] index = new int[len]; // индексы элементов исходного массива, которые войдут в результирующий массив 

    // вычисляем размер результирующего массива
    for (int i = 0; i < len; i++)
        if (array[i].Length <= lim) 
            index[k++] = i;

    // формируем результирующий массив
    string[] resArray = new string[k];    
    for (int j = 0; j < k; j++)
        resArray[j] = array[index[j]];
        
    return resArray;
}

// вывод массива
string PrintArray(string[] arr)
{
    string result = string.Empty;
    result = $"[{String.Join(", ", arr)}]";    

    return result;
}


Console.Clear();
string[] initialArray = {"hello", "2", "world", ":-)"};  // исходный массив строк
int trim = 3;  // условие на длину строк результирующего массива


Console.Write(PrintArray(initialArray) + " -> ");
string[] resultArray = GetFormedArray(initialArray, trim);
Console.WriteLine(PrintArray(resultArray));

// вариант вывода в файл проекта
File.WriteAllText("res.txt", PrintArray(initialArray) + " -> " + PrintArray(resultArray));

// тестирование
trim = 3;

string[] initialArray1 = {"1234", "1567", "-2", "computer science"}; 
Console.WriteLine();
Console.Write(PrintArray(initialArray1) + " -> ");
Console.WriteLine(PrintArray(GetFormedArray(initialArray1, trim)));

string[] initialArray2 = {"Russia", "Denmark", "Kazan"}; 
Console.WriteLine();
Console.Write(PrintArray(initialArray2) + " -> ");
Console.WriteLine(PrintArray(GetFormedArray(initialArray2, trim)));

trim = 7;

string[] initialArray3 = {"Russia", "Denmark", "Kazan"}; 
Console.WriteLine();
Console.Write(PrintArray(initialArray3) + " -> ");
Console.WriteLine(PrintArray(GetFormedArray(initialArray3, trim)));