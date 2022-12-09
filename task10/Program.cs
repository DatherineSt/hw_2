// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int userNumber = new int();
Console.WriteLine("Введите трехзначное число");
userNumber = Convert.ToInt32(Console.ReadLine());

int firstDigit = userNumber / 100;
int secondDigit = userNumber % 100 / 10;
int thirdDigit = userNumber % 10;
Console.WriteLine($"Вторая цифра этого числа - {secondDigit}");
