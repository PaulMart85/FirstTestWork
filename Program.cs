// формирование результирующего массива строк, длина которых меньше либо равна lim символов
string[] GetFormedArray(string[] array, int lim)
{
    string[] resArray = {};

    return resArray;
}

// вывод массива
string PrintArray(string[] arr)
{
    string result = string.Empty;    

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