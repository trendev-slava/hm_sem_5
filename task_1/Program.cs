int[] array = GetFillingArray(5);
PrintArray(array);
Console.WriteLine("-->" + NumberOfEvenDigits(array));

int[] GetFillingArray(int size)
{
    int[] array = new int[size];
    int index;
    for (index = 0; index < size; index++)
    {
        array[index] = new Random().Next(100, 1000);
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

int NumberOfEvenDigits(int[] array)
{
    int count = 0;
    int index;
    for (index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}