// Задача 1

// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// 1 вариант:

// int M = 4; 

// int N = 8;

// int firstNum=M;
// int secondNum=N;
// void PrintNumbers(int startNum, int endNum)
// {   
//     Console.Write(startNum + " ");
//     if (startNum >= endNum)
//     {
//         return;
//     }
//     PrintNumbers(startNum+1, endNum);
// }
// PrintNumbers(firstNum, secondNum);

// 2 вариант

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());


int firstNum=M;
int secondNum=N;
void PrintNumbers(int startNum, int endNum)
{   
    Console.Write(startNum + " ");
    if (startNum >= endNum)
    {
        return;
    }
    PrintNumbers(startNum+1, endNum);
}
PrintNumbers(firstNum, secondNum);
