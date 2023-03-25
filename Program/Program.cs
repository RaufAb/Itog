Console.Write("Сколько элементов нужно ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int ln = 3;
int zer = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    string e = Convert.ToString(Console.ReadLine());
    if (e.Length <= ln)
    {
        arrayStrings[zer] = e;
        zer++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}