// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.WriteLine("Введите целое число (делимое)");
int dividend = int.Parse(Console.ReadLine());

Console.WriteLine("Введите целое число (делитель)");
int divisor = int.Parse(Console.ReadLine());

if (dividend % divisor == 0) Console.WriteLine("Число " + dividend + " кратно числу " + divisor);
else 
{
    Console.WriteLine("Число " + dividend + " не кратно числу " + divisor);
    Console.WriteLine("остаток от деления равен " + dividend % divisor);
}
