// Программа из заданного массива строк формирует массив из строк, длина которых меньше или равна 3 символам.

Console.Clear();

// Печать массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

// Формирование массива из строк, длина которых меньше или равна 3 символам
string[] Line3(string[] array)
{
    int j = 0; int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) count++;

    string[] array2 = new string[count];
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        };
    return array2;
}

string[] array1 = new string[6] { "computer", "53", "world", "-5", "str", "hello" };
PrintArray(array1);
Console.Write($" -> ");
PrintArray(Line3(array1));
