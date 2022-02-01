// Показать числа от -N до N

Console.WriteLine("Введите число N");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Числа от -N до N");
for (int i = number*(-1); i <= number; i++) 
{
    Console.Write(i + " ");
}
