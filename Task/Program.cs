/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int LengthArray(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine()!);
    return result;
}

string [] GetArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение массива: ");
        array[i] = (Console.ReadLine()!);
    }
    return array;
}

string[] CountSymbolsInElement(string[] array)
{
    string[] temp = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        if (element.Length <= 3)
        {
           temp[count] = element;
           count++;
        }
    }

    string[] result = new string[count];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = temp[i];
    }
    return result;
}

void PrintArray (string message, string[] array)
{
    Console.WriteLine();
    Console.Write(message);
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

int length = LengthArray("Введите количество элементов в массиве: ");
string[] massive = GetArray(length);
PrintArray("Начальный массив: ", massive);
string[] result = CountSymbolsInElement(massive);
PrintArray("Конечный массив: ", result);
