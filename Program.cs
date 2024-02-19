// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] FilterStrings(string[] inputArray)
{
    int filteredCount = 0;

    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            filteredCount++;
        }
    }

    string[] filteredArray = new string[filteredCount];
        int index = 0;

    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            filteredArray[index] = str;
            index++;
        }
    }

     return filteredArray;
}

void PrintArray(string[] array, string text)
{
    Console.WriteLine($"{text}: [{string.Join(", ", array)}]");
}

//----------------------------------------------------
string[] inputArray = { "1234", "1567", "-2", "computer science" }; // Исходный массив задан изначально
string[] filteredArray = FilterStrings(inputArray);

PrintArray(inputArray, "Исходный массив");
PrintArray(filteredArray, "Отфильтрованный массив");
