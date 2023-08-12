// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трёхзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 < 100 || num1 >= 1000)
{
System.Console.WriteLine("Вы ввели не трехзначное число");
    return;
}

int num2 = num1 / 10 % 10;
System.Console.WriteLine($"Вторая цифра{num2}");

