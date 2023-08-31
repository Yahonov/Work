// Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел 
// от 1 до 50 и выводит их на экран.


int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}