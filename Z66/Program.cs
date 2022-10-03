//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum(int s)
{
    int result=0;
    for (int m=1; m<=n;m++) result += m;
    return result;
}
Console.WriteLine(sum(m));