// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int userNumber = new int();
Console.WriteLine("Введите цифру");
userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (userNumber / 1000 > 0)
    {
        Console.WriteLine($"Третьей цифрой является {userNumber / 10 % 10}");
    }
    else
    Console.WriteLine($"Третьей цифрой является {userNumber % 10}");
}
