// Ex43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем:   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void ConditionPoint(double a, double b, double c, double d)
{
    if ((a == c ) && (b == d ))   Console.WriteLine($"Прямые у = {a}х + {b} и у = {c}х + {d} совпадают и точек персечения бесконечно много");
        
    else if ((a == c ) && (b != d ))   Console.WriteLine($"Прямые у = {a}х + {b} и у = {c}х + {d} параллельны и точек персечения нет");
    
    else if (a != c)     Console.WriteLine($"Точка пересечения прямых у = {a}х + {b} и у = {c}х + {d} -->  ({(d - b)/(a - c)}; {a * ((d - b)/(a - c)) + b})");
}
Console.WriteLine("Введите коэффициенты k1, b1, k2, b2 уравнений прямых через Enter:");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
ConditionPoint(k1, b1, k2, b2);
