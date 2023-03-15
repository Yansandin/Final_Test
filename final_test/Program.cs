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