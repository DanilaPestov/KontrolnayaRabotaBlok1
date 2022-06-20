string[] mass = { "Hello", "2", "world", ":-)", "1", "22", "333", "4444", "5" };

string Print(string[] array)
{
    string res = string.Empty;
    res = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} +  ";
    }
    res += " ]";
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

Print(mass);
Console.WriteLine("новый массив с 3 и менее символами: ");
Result(mass);
