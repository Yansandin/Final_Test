string[] UserInputArray(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку №{i}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] ThreeCharArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] FinalArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            FinalArray[count] = array[i];
            count++;
        }
    }    
    return FinalArray;
}

void PrintArray(string[] printArr)
{
    Console.Write("[");
    for (int i = 0; i < printArr.Length; i++)
    {
        if (i == printArr.Length - 1)
            Console.Write($"\"{printArr[i]}\"");
        else
            Console.Write($"\"{printArr[i]}\", ");
    }
    Console.WriteLine("]");
}