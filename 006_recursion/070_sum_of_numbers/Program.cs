// Найти сумму цифр числа

int SumOfNumbers (int inputNumber)
{
    if (inputNumber < 10) return inputNumber;
    else return inputNumber % 10 + SumOfNumbers(inputNumber / 10);  
}


Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
if (number < 0) number = -number;

Console.WriteLine($"Сумма цифр числа равна {SumOfNumbers(number)}");
