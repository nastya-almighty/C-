Console.WriteLine("Введите ваше число римскими цифрами: ");
string roman = Console.ReadLine();
roman = roman.ToLower();

string newroman = roman.Replace('i', '1');
Console.WriteLine(newroman);


/*
string Replace(string roman, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = roman.Length;
    for(int j = 0; j < length; j++)
    {
        if(roman[j] == oldValue) result = result + $"{newValue}";
        else result = result + $"{roman[j]}";
    }
    return result;
}

string roman1 = Replace(roman, 'i', '1');
string roman2 = Replace(roman1, 'v', '2');
string roman3 = Replace(roman2, 'x', '3');
string roman4 = Replace(roman3, 'l', '4');
string roman5 = Replace(roman4, 'c', '5');
string roman6 = Replace(roman5, 'd', '6');
string roman7 = Replace(roman6, 'm', '7');

Console.WriteLine(roman7);


char[] arr = roman7.ToCharArray();
int size = arr.GetLength(0);

Console.WriteLine(size);
Console.WriteLine(String.Join(" ", arr));

int [] Translate1 (char [] arr, int size)
{
    int [] transl = new int [size];

    for (int j = 0; j < size; j++)
    {
        if (arr [j] == 1) transl [j] = 1;
        if (arr [j] == 2) transl [j] = 5;
        if (arr [j] == 3) transl [j] = 10;
        if (arr [j] == 4) transl [j] = 50;
        if (arr [j] == 5) transl [j] = 100;
        if (arr [j] == 6) transl [j] = 500;
        if (arr [j] == 7) transl [j] = 1000;
    }
    return transl;
    Console.WriteLine(string.Join(" ", transl)); 
}

Translate1(arr, size);

// Console.WriteLine(string.Join(" ", Translate1(arr, size)));
/*