// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное целое число");

int number = int.Parse(Console.ReadLine());

if (Math.Abs(number / 100) < 1 | Math.Abs(number / 100) > 9)
{
    Console.WriteLine("Число не трехзначное");
    return;
}

number = number/100*10 + number%10;
Console.WriteLine("Число без второй цифры {0}", number);
