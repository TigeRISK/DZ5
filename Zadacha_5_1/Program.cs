// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] numbers = new int[4];
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++){}
    Console.Write("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
}
int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            quantity++;
        }
    }
    return quantity;
}
FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();
int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");