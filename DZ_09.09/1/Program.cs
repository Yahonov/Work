//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,999);
}

void EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2==1)
        count = count + 1;
    Console.WriteLine($"Количество элементов {count}");
}

int[] array = new int[5];

FillArray(array);
EvenNumber(array);
