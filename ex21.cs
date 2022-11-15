// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = SetNumber("x1");
int y1 = SetNumber("y1");
int z1 = SetNumber("z1");
int x2 = SetNumber("x2");
int y2 = SetNumber("y2");
int z2 = SetNumber("z2");

double result = DistanceBetween3DPoints(x1, x2, y1, y2, z1, z2);

System.Console.WriteLine($"result {result}");
