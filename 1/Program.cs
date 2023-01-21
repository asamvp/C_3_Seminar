// координаты точки и номер четверти

int Promt(string message) //ввод значения
{
    System.Console.Write($"{message}>");
    return Convert.ToInt32(Console.ReadLine());
}
bool ValidateCoords(int xCoord, int yCoord)//проверка на ось
{
    if (xCoord == 0 || yCoord == 0)
    {
        System.Console.WriteLine("Точка лежит хотя бы на оджной из осей");
        return false;
    }
    return true;
}
int Getquarter(int xCoord, int yCoord)
{
    if (xCoord > 0 && yCoord > 0)
    {
        return 1;
    }
    if (xCoord < 0 && yCoord > 0)
    {
        return 2;
    }
    if (xCoord < 0 && yCoord < 0)
    {
        return 3;
    }
    return 4;
}

int x = Promt("Введите x");
int y = Promt("Введите y");
if (ValidateCoords(x, y))
{
    System.Console.WriteLine($"Точка лежит в плоскости номер {Getquarter(x,y)}");
}