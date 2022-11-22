void ViewArray()
{
    Console.Clear();
    int size = SetNumber("size");
    int minValue = SetNumber("minValue");
    int maxValue = SetNumber("maxValue");
    int [] array = GetRandomArray(size, minValue, maxValue);
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(minValue, maxValue);
    }
    return result;
}