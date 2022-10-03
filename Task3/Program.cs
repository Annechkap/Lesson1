// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while(count<=n)
{
    Console.WriteLine(count);
    count=count+1;
}
