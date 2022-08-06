// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] arrayRealNumbers = new double[5];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 10);
}
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}
double decision = maxNumber - minNumber;
Console.Write("Массив: {0}{1}{2}", "[", String.Join(", ", arrayRealNumbers), "]");
Console.WriteLine($"\nРазница между: {maxNumber} - {minNumber} = {decision}");