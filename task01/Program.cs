// напишите программу,которая
// на вход принимает 2 числа и проверяет
// является ли первое число квадратом второго
// а = 25 , в = 5 -> да
// а = 3 , в = 9 -> нет

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)
{
    Console.WriteLine($"{a} ,квадрат {b}");
}
else
{
    Console.WriteLine($"{a} ,не квадрат {b}");
}



