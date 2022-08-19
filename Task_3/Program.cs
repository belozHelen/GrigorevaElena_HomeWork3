// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



int number = ReadInt("Введите число: ");
int i = 1;

while(i <= number)
{
    Console.Write(Sqr(i) + " ");
    i++;
}

int Sqr(int a)
{
    return a * a * a;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}