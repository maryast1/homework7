// Задача 3: Задайте произвольный массив. Выведите его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
// class Program

void PrintArrayRevers(int[] array, int first = 0)
{
    if(first != array.Length) {
        PrintArrayRevers(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}

void Main(string[] args)
{
    var array = new int[]{1, 2, 5, 0, 10, 34};
    PrintArrayRevers(array);

}
Main(args);
