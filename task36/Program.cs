/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int size = 10;
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях, равна: " + SumNumbers(array));

int SumNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 20);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
