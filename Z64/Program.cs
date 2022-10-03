//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int b=1;
string numbers (int n, int b)
{
    if (n <= b) return numbers (n+1,b)+ $"{n} ";
    else return String.Empty;
}
Console.WriteLine(numbers(b,n));