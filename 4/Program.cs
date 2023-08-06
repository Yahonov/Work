// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (num1 >= i)
{
    System.Console.Write(i + " ");
     i = i + 2;
}