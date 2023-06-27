// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetRandomArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue + 1) + minValue;
    }
    return result;
}
void Minmax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
        if (array[i]>max) max = array[i];
    }
    System.Console.WriteLine($"минимальное значение {min:f2}");
    System.Console.WriteLine($"максимальное значение {max:f2}");
    System.Console.WriteLine($"разница {max-min:f2}");
}
double[] arr = GetRandomArray(5,-10,10);
System.Console.WriteLine(String.Join(" ", arr ));
Minmax(arr);