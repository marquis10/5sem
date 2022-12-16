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
    z = array[i];
    z *= (-1);
    array[i] = z;
Console.WriteLine($"Элементы заменены: {array}");
}

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ZamenaArray(array);