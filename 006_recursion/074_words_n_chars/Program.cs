// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, 
// которые можно построить из букв этого алфавита

string ShowWords(string[] chars, string quaternaryNum, int charsNum)
{
    if (charsNum == 1) return chars[Convert.ToInt32(quaternaryNum[^1].ToString())]; 
    else return chars[Convert.ToInt32(quaternaryNum[^charsNum].ToString())] 
        + ShowWords(chars, quaternaryNum, --charsNum);
}

// Convert to another number system
string ConvertToAnother(int inputDecimal, int baseNum)
{
    if (inputDecimal < baseNum) return inputDecimal.ToString();
    else return (ConvertToAnother(inputDecimal / baseNum, baseNum)).ToString() 
                + (inputDecimal % baseNum).ToString();
}

Console.WriteLine("Задайте количество букв в слове");
Console.Write("n=");
int charactersNumber = int.Parse(Console.ReadLine());
string[] characters = {"а", "и", "с", "в", "ы"};

int wordsNumber = Convert.ToInt32(Math.Pow(characters.Length, charactersNumber));

Console.WriteLine($"Слова, состоящие из {charactersNumber} букв");
for (int i = 0; i < wordsNumber; i++) 
{
    string anotherNumber = ConvertToAnother(i, characters.Length);
    // Fill null digits with zeros
    while (anotherNumber.Length < charactersNumber) anotherNumber = "0" + anotherNumber;
    
    Console.Write($"{ShowWords(characters, anotherNumber, charactersNumber)} ");
}
