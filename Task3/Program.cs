// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Какой сейчас у Вас день недели (в цифре)?");
int day = Convert.ToInt32(Console.ReadLine());
while (day <= 5 && day > 0)
    {
        Console.Write("Нет");
        break;
    }
while (5 < day && day < 8)
    {
        Console.Write("Да");
        break;
    }



