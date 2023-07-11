// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

void Squere(int number1, int number2)
{    
    if (number1 * number1 % number2 == 0 || number2 * number2 % number1 == 0)// || Это означает "или"
    {
        Console. WriteLine("-> да");
    }       
    else
    {
        Console. WriteLine("-> нет");
    }    
}

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Squere(num1, num2);
