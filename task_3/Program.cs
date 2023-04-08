int[] array = GetFillingArray(5);
PrintArray(array);
Console.WriteLine("-->" + DifferenceMaximumMinimum(array));


int[] GetFillingArray(int size)
{
    int[] array = new int[size];
    int index;
    for (index = 0; index < size; index++)
    {
        array[index] = new Random().Next(0, 101);//  нужны не целые числа, а вещественные
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

int DifferenceMaximumMinimum(int[] array)
{
    int diff = 0;
    int max = array[0];
    int min = array[0];
    int index;
    for (index = 1; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            int temp = max;
            max = array[index];
            array[index] = temp;
        }
        else if (array[index] < min)
        {
            int temp = min;
            min = array[index];
            array[index] = temp;
        }

    }
    diff = max -min;
    return diff;
}