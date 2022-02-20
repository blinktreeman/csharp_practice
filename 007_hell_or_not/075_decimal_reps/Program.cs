// Составить массив десятичных представлений чисел массива data 
// с учётом информации из массива info.

// Make arrays data, info
int[] data = new int[60] { 0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1,
                        0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0,
                        1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1,
                        1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
// sum of info numbers = data.lenght
int[] info = new int[] { 3, 2, 1, 2, 3, 1, 3, 1, 2, 1, 2, 3, 2, 3, 1, 
                        3, 1, 2, 1, 2, 3, 3, 1, 2, 2, 3, 1, 1, 2, 3 };

int BinaryToDecimal(int[] inputBinary)
{
    int decimalNumber = 0;
    for (int i = 0; i < inputBinary.Length; i++)
    {
        decimalNumber += inputBinary[i] * Convert.ToInt32(Math.Pow(2, inputBinary.Length - i - 1));
    }
    return decimalNumber;
}

int[] GetBinaryNumber(int fromIndex, int numberLenght)
{
    int[] binaryArray = new int[numberLenght];
    for (int i = 0; i < numberLenght; i++) binaryArray[i] = data[fromIndex + i];
    return binaryArray;
}

int[] decimalArray = new int[info.Length];
int currentDataIndex = 0;
int currentDecimalArrayIndex = 0;

foreach(int i in info)
{
    decimalArray[currentDecimalArrayIndex] = BinaryToDecimal(GetBinaryNumber(currentDataIndex, i));
    currentDataIndex += i;
    currentDecimalArrayIndex ++; 
} 

Console.WriteLine("Двоичные данные");
Console.WriteLine(string.Join(" ", data));
Console.WriteLine("Массив с количеством бит");
Console.WriteLine(string.Join(" ", info));
Console.WriteLine("Десятичное представление");
Console.WriteLine(string.Join(" ", decimalArray));
