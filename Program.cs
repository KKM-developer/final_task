/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string [] FillArray()
{
    Console.Write("Введите количество элементов массива ");
    int countElement = Convert.ToInt32(Console.ReadLine());
    string [] array = new string[countElement];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        Console.Write(table[i] + "\t");
    }
}

string [] CheckArray (string [] someArray)
{
    int count = 0;
    foreach (string item in someArray)
    {
        if (item.Length <= 3) count ++;
    }
    string [] returnList = new string[count];
    count = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i].Length <= 3)
        {
            returnList[count] = someArray[i];
            count++;
        }
    }
    return returnList;
}
string [] user_list = FillArray();
PrintArray(user_list);
Console.WriteLine();
PrintArray(CheckArray(user_list));