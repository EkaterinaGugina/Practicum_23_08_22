// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int n1=n;
int l=0;
while(n>0)
{
n=n/2;
l++;
}
int[] arr = new int[l];
int i = 0;
for (int b=0; i < arr.Length; n1/=2)
{
    b = n1 % 2;
    arr[arr.Length-1-i]=b;
    i++;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}
PrintArray(arr);


