// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, 
// которые можно построить из букв этого алфавита

string ShowWords(string[] chars, string quaternaryNum, int charsNum)
{
    if (charsNum == 1) return chars[Convert.ToInt32(quaternaryNum[^1].ToString())]; 
    else return chars[Convert.ToInt32(quaternaryNum[^charsNum].ToString())] 
        + ShowWords(chars, quaternaryNum, --charsNum);
}

// Convert to quaternary number
string ConvertToQuaternary(int inputDecimal)
{
    if (inputDecimal < 4) return inputDecimal.ToString();
    else return (ConvertToQuaternary(inputDecimal / 4)).ToString() 
                + (inputDecimal % 4).ToString();
}

Console.WriteLine("Задайте количество букв в слове");
Console.Write("n=");
int charactersNumber = int.Parse(Console.ReadLine());
string[] characters = {"а", "и", "с", "в"};

int wordsNumber = Convert.ToInt32(Math.Pow(characters.Length, charactersNumber));

Console.WriteLine($"Слова, состоящие из {charactersNumber} букв");
for (int i = 0; i < wordsNumber; i++) 
{
    string quaternaryNumber = ConvertToQuaternary(i);
    // Fill null digits with zeros
    while (quaternaryNumber.Length < charactersNumber) quaternaryNumber = "0" + quaternaryNumber;
    
    Console.Write($"{ShowWords(characters, quaternaryNumber, charactersNumber)} ");
}
