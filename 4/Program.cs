/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
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
    System.Console.Write($"{Math.Pow(i, 2)}, ");
    i++;
}