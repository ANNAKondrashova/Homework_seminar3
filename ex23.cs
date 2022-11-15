// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int num = SetNumber("N");
int[] arr = CubeTable(num);
System.Console.WriteLine(String.Join(",", arr));
