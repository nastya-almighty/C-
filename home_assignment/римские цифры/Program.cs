Console.WriteLine("Введите ваше число римскими цифрами: ");
string roman = Console.ReadLine();
roman = roman.ToLower();

char[] arr = roman.ToCharArray();
int size = arr.GetLength(0);

int [] Replace(char [] arr, int size)
{
    int [] transl = new int [size];
    for (int j = 0; j < size; j++)
    {
        if (Convert.ToChar(arr[j]) == 'i') transl [j] = 1;
        if (Convert.ToChar(arr[j]) == 'v') transl [j] = 5;
        if (Convert.ToChar(arr[j]) == 'x') transl [j] = 10;
        if (Convert.ToChar(arr[j]) == 'l') transl [j] = 50;
        if (Convert.ToChar(arr[j]) == 'c') transl [j] = 100;
        if (Convert.ToChar(arr[j]) == 'd') transl [j] = 500;
        if (Convert.ToChar(arr[j]) == 'm') transl [j] = 1000;
    }
    return transl;
}
int [] newArray = Replace(arr, size);

int Arab (int [] a)
{
    int si = a.GetLength(0);
    int sum = 0;
    for (int j = 0; j < si; j++)
    {
        if ((j + 1) == si)
        {
            sum = sum + a[j];
        }
        else
        {
            if (a[j] >= a[j + 1])
            {
                sum = sum + a[j];
            }
            else 
            {
                sum = sum - a[j];
            }   
        }
    }
    return sum;
}

Console.Write("конвертация в арабские числа - ");
Console.WriteLine(Arab(newArray));