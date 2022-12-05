// Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
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

if (number < 100) Console.WriteLine("Третьей цифры нет!");

else {

while (number > 1000) {
    number = number / 10;
}

int thirdDigit = number % 10;
Console.WriteLine("Третье число: " + thirdDigit);
}