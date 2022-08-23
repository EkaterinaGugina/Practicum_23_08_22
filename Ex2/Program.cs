// Ex40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

void Condition(int a, int b, int c)
{
    if ((a + b > c) && (b + c > a) && (c + a > b))
        {
            Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существует");
        }
    else  Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} не существует");
}

Console.WriteLine("Введите три числа - длины сторон");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
Condition(num1, num2, num3);
