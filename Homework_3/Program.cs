/*Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Promt(string message) //ввод значения
{
    System.Console.Write($"{message}>");
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int N = Promt("Введите N ");
int i = 1;
while (i <= N)
{
    System.Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}