// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само сеья), например: 4->16, 3->9, 7->49

int Prompt(string message)
{
    Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int value = Prompt("Введите число >   ");
int square = value * value;
Console.WriteLine($"Квадрат числа {value} равен {square}");
