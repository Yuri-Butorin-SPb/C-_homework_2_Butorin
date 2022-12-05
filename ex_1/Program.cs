// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное число: ");
bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse (Console.ReadLine(), out number);
    if (isParsed == false)
    {
        Console.WriteLine ("Ошибка! Недопустимые символы.");
    }
}

int secondDigit = number / 10 % 10;

Console.WriteLine (secondDigit);
