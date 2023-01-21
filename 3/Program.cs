/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

int Promt(string message) //ввод значения
{
    System.Console.Write($"{message}>");
    return Convert.ToInt32(Console.ReadLine());
}
double Distance(double x1, double x2, double y1, double y2)
{
    double a = 0.0, b = 0.0;
    a = x2 - x1;
    b = y2 - y1;
    return Math.Sqrt(a*a + b*b); 
}

Console.Clear();
int x1 = Promt("Введите x1");
int y1 = Promt("Введите y1");
int x2 = Promt("Введите x2");
int y2 = Promt("Введите y2");
System.Console.WriteLine($"Расстояние между точками-> {Distance(x1,y1,x2,y2)}");
