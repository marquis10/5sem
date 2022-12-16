Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);    
}

void ZamenaArray(int[] array)
{
    int z = 0;
    for (int i = 0; i < array.Length; i++)
    array[i] *= (-1);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
}

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ZamenaArray(array);