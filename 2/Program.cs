// программа которая по номеру четверти показывает диапазон возможных точек
int Promt(string message) //ввод значения
{
    System.Console.Write($"{message}>");
    return Convert.ToInt32(Console.ReadLine());
}
bool ValidateCoords(int xCoord)//проверка на значение
{
    if (xCoord < 1 || xCoord > 4)
    {
        System.Console.WriteLine("Такой четверти нет");
        return false;
    }
    return true;
}
string Getquarter(int xCoord)
{
    if (xCoord==1)
    {
        return "x>0 y>0";
    }
    if (xCoord==2)
    {
        return "x<0 y>0";
    }
    if (xCoord==3)
    {
        return "x<0 y<0";
    }
    if (xCoord==4)
    {
        return "x>0 y<0";
    }
    return "ошибка";
}

int x = Promt("Введите номер четверти");
if (ValidateCoords(x))
{
    //Getquarter(x);
    System.Console.WriteLine($"Ответ: {Getquarter(x)}");
}