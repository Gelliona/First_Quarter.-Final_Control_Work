Console.Clear();

Console.Write("Введите слова, числа или наборы символов через запятую: ");
string inputString = Console.ReadLine()!;

string[] array = ParseToArray(inputString);
Console.WriteLine("[" + string.Join((", "), array) + "]");

string[] newArray = ThreeSymbolsElementArray(array);
Console.WriteLine("[" + string.Join(", ", newArray) + "]");



string[] ParseToArray(string str)            
{
    string[] stringArray = str.Split(",");
    string[] result = new string[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = stringArray[i];
    }

    return result;
}

string[] ThreeSymbolsElementArray(string[] inputArray)
{
    int newSize = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
            newSize++;
    }

    string[] resultArray = new string[newSize];
    
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[j] = inputArray[i];
            j++;
        }        
    }
    return resultArray;
}
