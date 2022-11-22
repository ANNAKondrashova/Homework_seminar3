void MyPow()
{
    Console.Clear();
    int num = SetNumber("");
    int degree = SetNumber("degree of");
    Console.WriteLine($"{num} в степени {degree} = {Pow(num, degree)}");
}

int Pow(int num, int rank)
{
    if (rank == 0) return 1;
    else if (rank == 1) return num;
    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}