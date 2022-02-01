// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное целое число");

int number = int.Parse(Console.ReadLine());

if (number/100 < 1 ^ number/100 > 9)
{
    Console.WriteLine("Число не трехзначное");
    return;
}

Console.WriteLine("Вторая цифра числа " + number/10%10);