//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write($"Введи количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int RandomNumbers(int elements, int min, int max)
{
    int[] random = new int[elements];
    int sum = 0;
    for (int i = 0; i < random.Length; i++)
    {
        random[i] = new Random().Next(min, max);
        if (i % 2 != 1)
        {
            sum += random[i];
        }
    }
    Console.Write("Массив: {0}{1}{2}", "[", String.Join(", ", random), "]");
    return sum;
}
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {RandomNumbers(num, 1, 10)}");