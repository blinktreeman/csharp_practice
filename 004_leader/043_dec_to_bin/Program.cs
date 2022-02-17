// Написать программу преобразования десятичного числа в двоичное
// Решение с помощью разложения на степени двойки - 2^n+...+2^1+2^0  

// 9 = 1*2^3 + 0*2^2 + 0*2^1 + 1*2^0 = 1001 
/*
9%2 1 
9/2 4
4%2 0
4/2 2
2%2 0
2/2 1
*/


int findDigitIndex(int number)
{
    int count = 0;
    // Находим показатель степени 2     
    while (Math.Pow(2, count) <= number / 2) count++;    
    return (count);
}

Console.WriteLine("Введите десятичное число");
int decimalNum = int.Parse(Console.ReadLine());
string negFlag = String.Empty;
if (decimalNum < 0)             // Для отрицательных чисел
{
    decimalNum = Math.Abs(decimalNum);
    negFlag = "-";
}

// Определяем индекс старшего разряда двоичного числа
int idx = findDigitIndex(decimalNum);

// Объявляем массив необходимой длины
int[] arrayBin = new int[idx+1];

// Старший разряд первый в массиве. "1" если исходное число не "0"
arrayBin[^(idx+1)] = decimalNum != 0 ? 1 : 0;

// Вычитаем из исходного числа 
decimalNum -= Convert.ToInt32(Math.Pow(2, idx));

// Для остатка находим показатели степеней для разрядов
while (decimalNum >= 1)
{
    idx = findDigitIndex(decimalNum);
    decimalNum -= Convert.ToInt32(Math.Pow(2, idx));
    arrayBin[^(idx+1)] = 1;
} 

Console.WriteLine("Двоичное представление числа" );
Console.WriteLine(negFlag + String.Join("", arrayBin));
