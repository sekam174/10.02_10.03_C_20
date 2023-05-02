// Напишите программу, которая
// на вход принимает два числа и выдаёт
// какое число больше, а какое меньше

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
 if(number1 > number2)
{
    int maxNumber = number1;
    Console.WriteLine($"max = {maxNumber}");
}
else if(number2 > number1)
{
    int maxNumber = number2;
    Console.WriteLine($"max = {maxNumber}");
}
