// See https://aka.ms/new-console-template for more information

int SizeNumBinary(int num)   //считаем кол-во цифр в бинарном представлении числа
{
    int size = 0;
    while (num > 0)
    {
        num = num / 2;
        size++;
    }
    return size;
}

int[] BinaryNumber(int num, int[] arr)       //создаем массив - двоичную запись числа num
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[arr.Length - 1 - i] = num % 2;
        num /= 2;
    }
    return arr;
}

void PrintArray(int[] arr)             // вывод на печать массива, содержащего двоичную запись числа
{
    for (int i = 0; i < arr.Length; i++)  Console.Write(arr[i]);
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int size_binary = SizeNumBinary(n);
int[] array42 = new int[size_binary];
array42 = BinaryNumber(n, array42);
PrintArray(array42);

