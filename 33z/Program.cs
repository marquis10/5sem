Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}

string SearchChisla(int[] array, int numb)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (numb == array[i])
            return ($"Число {numb} имеется в массиве");       
    }
    return ($"Числа {numb} нет в массиве"); 
}

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine("Введите искомое число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchChisla(array, chislo));