// Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример
// m = 2, n = 3 -> A(m,n) = 29 



Console.WriteLine("Введите неотрицательное число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman (int m, int n)
{   
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }            
    
}
Console.WriteLine($"Функция Аккермана равна {FunctionAkkerman (m, n)}");
