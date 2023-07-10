// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int GetRandomNumber()// Cоздаём метод, который создат случайный number
{
    int number = new Random().Next(10, 100); // Создаюм случайное число от 10 до 99. Правую границу метод Next не включает
    //Console.WriteLine(number); //Нужна была для проверки числа 
    return number;
}

int GetFirstDigit(int number1)// Из числа вытаскиваем первую цифру
{
    //number1 = number1 / 10; Можно без этой строки, если всё прописать в return
    return number1 / 10;
}

int GetLastDigit(int number1)// Из числа вытаскиваем последнюю цифру
{
    return number1 % 10;
}

void PrintNumber(int num1)// метод будет печатать какое-то значения, назвали его num1. При этом возвращать значение не нужно, просто печать.
{
    Console.Write(num1 + " ");
}

void ShowLargestDigit(int digit1, int digit2)
{
    if(digit1 > digit2)
    {
        Console.Write("-> " + digit1);
    }
    else Console.Write("-> " + digit2);
}

int num = GetRandomNumber(); //Передаём зачение, которое метод сгенерировал в новую переменную num

PrintNumber(num);// Печатаем через метод. Вместо num1 вставляем нужное нам значение num

int firstDigit = GetFirstDigit(num);//Передаём зачение первой цифры числа в новую переменную

//PrintNumber(firstDigit);//Печатаем через метод. Вместо num1 вставляем нужное нам значение firtsDigit

//Console.WriteLine(firstDigit); Эта строка не нужна, если печатаем через метод

int lastDigit = GetLastDigit(num);//Передаём зачение последней цифры числа в новую переменную
//PrintNumber(lastDigit); // Убрали лишнее для красоты вывода
ShowLargestDigit(firstDigit, lastDigit);// Вызываем метод для сравнения первой цифры и второй числа

Console.WriteLine();// Всё что ниже создаст ещё число и обработает так-же как первое число
int num2 = GetRandomNumber();
PrintNumber(num2);
int firstDigit2 = GetFirstDigit(num2);
int lastDigit2 = GetLastDigit(num2);
ShowLargestDigit(firstDigit2, lastDigit2);

