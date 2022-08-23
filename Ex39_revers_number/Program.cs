// Ex39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
 
void FillArray(int[] array)       //заполнение массива случайными числами и вывод на экран
{
    for (int index = 0; index < array.Length; index++)  array[index] = new Random().Next(-99, 100);
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void ReversArray(int[] arr)             // вывод на печать реверсом данного массива
{
    Console.Write("[");
    for (int pozition = arr.Length - 1; pozition > 0; pozition--)
    {
        Console.Write($"{arr[pozition]}, ");
    }
    Console.Write($"{arr[0]}]");
}

Console.Write("Введите размер массива, size = ");  //заполнение и печать массива
int size = Convert.ToInt32(Console.ReadLine());
int[] array39 = new int[size];
FillArray(array39);
Console.WriteLine();
ReversArray(array39);
