/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int size = 10;
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве равно: " + CountPositive(array));

int CountPositive(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count+=1;
        }
    }
    return count;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
