
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
