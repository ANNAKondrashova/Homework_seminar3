void SumNumbers()
{
    Console.Clear();
    int num = SetNumber("N");
    Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
}

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}