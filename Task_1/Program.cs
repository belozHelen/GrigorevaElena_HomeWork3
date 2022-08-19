// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.Write("Введите пятизначное число: ");

string? numberString = Console.ReadLine();

if (numberString != null) {
    int length = numberString.Length;
    bool trigger = false;

    if (length == 5) {
        for (int i = 0; i <= 4; i++) {
            string num = Convert.ToString(numberString[i]);
            int nextIndex = 4 - i;
            string mirror = Convert.ToString(numberString[nextIndex]);
            if (num == mirror) {
                continue;
            } else {
                trigger = true;
            }
        }

        if (trigger) {
            Console.WriteLine("Не является палиндромом");
        } else {
            Console.WriteLine("Является палиндромом");
        }
    } else {
        Console.WriteLine("число не является 5-значным");
    }
}