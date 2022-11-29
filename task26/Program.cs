/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
int SumOfRange (int start, int finish)
{
    int sum = 0;
    for (int i = start; i < finish; i++)
    {
        sum += i;
    }
    return sum;
}

int getNumberFromUser(string message)
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;// цвет текста
    Console.WriteLine(message);
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = getNumberFromUser("Введите А для подсчета суммы 1..А");
int sum = SumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1 .. {userNumber} = {sum}");