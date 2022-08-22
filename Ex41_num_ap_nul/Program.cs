// Ex41 - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    // 0, 7, 8, -2, -2 -> 2           1, -7, 567, 89, 223-> 3

void NumbersApNul(int kolvo)
{
    Console.WriteLine();
    Console.WriteLine("Введите числа через Enter");
    int count = 0;
    for (int i = 1; i <= kolvo; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    Console.WriteLine($"Количество чисел, больших нуля, равно {count}");
}
Console.Write("Задайте количество вводимых чисел, М = ");
int M = Convert.ToInt32(Console.ReadLine());
NumbersApNul(M);
