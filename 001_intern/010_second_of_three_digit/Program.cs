// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное целое число");

int number = int.Parse(Console.ReadLine());

if (Math.Abs(number / 100) < 1 | Math.Abs(number / 100) > 9)
{
    Console.WriteLine("Число не трехзначное");
    return;
}

Console.WriteLine("Вторая цифра числа {0}", Math.Abs(number/10%10));