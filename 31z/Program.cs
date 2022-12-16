// task 31
Console.Clear();
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ReleaseArray(int[] array)
{
int sumPositive = 0, sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
sumPositive += array[i]; // s = s + a[i]
else
sumNegative += array[i];
}
Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);