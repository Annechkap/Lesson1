//Напишите программу, которая будет выдавать название недели по заданному номеру

Console.WriteLine("Введите номер дня недели   ");
int day = Convert.ToInt32(Console.ReadLine());
string[] days = {"Понедельние", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if(day <1|| day>7)
{
    Console.WriteLine($"Такого дня недели не существует");
}
else
{
    Console.WriteLine(days[day-1]);
}
