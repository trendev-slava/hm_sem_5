int[] array = GetFillingArray(5);
PrintArray(array);
Console.WriteLine("-->" + SumOddNumbers(array));




int[] GetFillingArray(int size)
{
    int[] array = new int[size];
    int index;
    for (index = 0; index < size; index++)
    {
        array[index] = new Random().Next(0, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    int index;
    for (index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
}

int SumOddNumbers(int[] array)
{
    int index;
    int sum = 0;
    for (index = 0; index < array.Length; index += 2)
    {
        sum += array[index];
    }
    return sum;
}