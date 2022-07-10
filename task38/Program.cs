/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int size = 10;
double[] array = new double[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элемментом равна: " + FindingDiff(array));

double FindingDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    else
    {
        if(array[i] < min)
        min = array[i];
    }
    }
    double result = max - min;
    return result;
}

void FillArray(double[] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
