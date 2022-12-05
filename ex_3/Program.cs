// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
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

if (number > 7) Console.WriteLine ("Такого дня недели не бывает!");

else {
    if (number < 6) Console.WriteLine ("Сегодня рабочий день :(");
    else Console.WriteLine ("Сегодня выходной");
}
