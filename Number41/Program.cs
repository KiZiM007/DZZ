// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество проверяемых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] Amount(int size1)
{
    int[] massiv = new int[size1];
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        massiv[i] = num;
    }
    return massiv;
}
int[] massiv = Amount(size);

int SumNumber(int[] massiv1)
{
    int sum = 0;
    for (int i = 0; i < massiv1.Length; i++)
    {
        if (massiv1[i] > 0) sum++;
    }
    return sum;
}
int sum = SumNumber(massiv);

void Print(int[] end)
{
    Console.Write("[");
    for (int i = 0; i < end.Length; i++)
    {
        if (i < end.Length - 1) Console.Write($"{end[i]}, ");
        else Console.Write($"{end[i]}");
    }
    Console.Write("]");
}
Print(massiv);
Console.WriteLine($" -> {sum}");