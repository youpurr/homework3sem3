// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0, num = number;
while (number > 0) {a = a * 10 + number % 10; number /= 10;}
Console.WriteLine(num == a ? "палиндром" : "не палиндром");
