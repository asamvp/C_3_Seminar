/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да*/
int Promt(string message) //ввод значения
{
    System.Console.Write($"{message}>");
    return Convert.ToInt32(Console.ReadLine());
}
string Palindrom(int N)
{
    if (N == 0)
    {
        return "Это Палиндром!";
    }
    if (N < 0 || N % 10 == 0)
    {
        return "НЕ палиндром";
    }
    int temp = 0;
    int preN = N;
    int right=0;
    while (N > temp)
    {
        right = N % 10;
        preN = N;
        N /= 10;
        temp = temp * 10 + right;
    }
    if (N == temp || preN == temp)
        return "Это Палиндром!";
    // 
    else
        return "НЕ палиндром";
}

Console.Clear();
int N = Promt("Введите число -- ");
System.Console.Write($"Ответ --> {Palindrom(N)}");