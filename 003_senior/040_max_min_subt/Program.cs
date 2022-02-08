// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arrayA = new double[10] {11.1, 2.5, 7.3, -2.2, 10.4, 0.6, -4.1, 8.8, 3.9, -0.9};

double maxNum = arrayA[0];
double minNum = arrayA[0];

for (int i = 1; i < arrayA.Length; i++)
{
    maxNum = arrayA[i] > maxNum ? arrayA[i] : maxNum;
    minNum = arrayA[i] < minNum ? arrayA[i] : minNum;
}

Console.WriteLine($"Разница между максимальным ({maxNum}) и минимальным ({minNum}) элементом равна {maxNum - minNum}");
