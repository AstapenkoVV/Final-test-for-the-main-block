/* Задача: 
Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

using System.Linq.Expressions;
using System.Runtime.InteropServices;

string[] messageArray = new string[] { "Hello", "2", "world", ":-)"};
string[] array = ResultArray(messageArray);
Console.Clear();
PrintArray(messageArray);
Console.Write(" -> ");
PrintArray(array);

string[] ResultArray(string[] array)
{
    int count = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    if (newArray.Length > count + 1)
        Array.Resize(ref newArray, count);
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" {" + array[i] + "} ");
    }
    Console.Write("]");
}