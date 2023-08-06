//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число первое");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine($"{num1} большее");
    System.Console.WriteLine($"{num2} меньшее");
}
if (num2 > num1)
{
    System.Console.WriteLine($"{num2} большее");
    System.Console.WriteLine($"{num1} меньшее");
}