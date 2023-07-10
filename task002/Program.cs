// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int GetRandomNumber()
{
    int number = new Random().Next(100, 1000); 
    return number;
}
int GetFirstDigit(int number1)
{
    return number1 / 100;
}
int GetLastDigit(int number1)
{
    return number1 % 10;
}
void PrintNumber(int num1)
{
    Console.Write(num1);
}

int num = GetRandomNumber();
PrintNumber(num);
Console.Write(" -> ");
int firstDigit = GetFirstDigit(num);
int lastDigit = GetLastDigit(num);
PrintNumber(firstDigit);
PrintNumber(lastDigit);
