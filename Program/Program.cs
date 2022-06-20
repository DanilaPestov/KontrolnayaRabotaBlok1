Console.Clear();
string[] mass = { "Hello", "2", "world", ":-)", "1", "22", "333", "4444", };

string Print(string[] array)
{
    string res = string.Empty;
    Console.WriteLine("массив элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

string[] Result(string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
            Console.Write(result[i] + " ");
        }
    }
    Console.WriteLine();
    return result;
}

Console.WriteLine(Print(mass));
Console.WriteLine();

Console.WriteLine("массив, состоящий из 3 и менее символов: ");
Result(mass);
Console.WriteLine();
