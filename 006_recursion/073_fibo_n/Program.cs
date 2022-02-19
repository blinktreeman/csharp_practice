// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void ShowNumbers(int firstNum, int secondNum, int nums)
{
    if (nums == 0) return;
    else
    {
        Console.Write($"{firstNum + secondNum} ");
        ShowNumbers(secondNum, firstNum + secondNum, --nums);
    } 
    
}

Console.WriteLine("Задайте первое число последовательности");
Console.Write("A=");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число последовательности");
Console.Write("B=");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество чисел последовательности для вывода");
Console.Write("N=");
int numbers = int.Parse(Console.ReadLine());

Console.WriteLine("Числовая последовательность ");
ShowNumbers(firstNumber, secondNumber, numbers);