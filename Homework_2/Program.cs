/*Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int Promt(string message) //ввод значения
{
    System.Console.Write($"{message}>");
    return Convert.ToInt32(Console.ReadLine());
}
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double a = 0.0, b = 0.0, c = 0.0;
    a = x2 - x1;
    b = y2 - y1;
    c = z2 - z1;
    return Math.Sqrt(a * a + b * b + c * c);
}
Console.Clear();
int x1 = Promt("Введите x1");
int y1 = Promt("Введите y1");
int z1 = Promt("Введите z1");
int x2 = Promt("Введите x2");
int y2 = Promt("Введите y2");
int z2 = Promt("Введите z2");
System.Console.WriteLine($"Расстояние между точками-> {Distance(x1, x2, y1, y2, z1, z2)}");