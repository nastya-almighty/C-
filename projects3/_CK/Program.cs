Console.WriteLine("введите свой текст ");
string text = (Console.ReadLine());

// string s = "qwerty"
// s[3] - r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string newText2 = Replace(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();

string newText3 = Replace(newText2, 'с', 'С');
Console.WriteLine(newText3);
Console.WriteLine();