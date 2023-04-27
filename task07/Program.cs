// напишите программу, которая 
// на вход принимает трёхзначное число
// а на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.Write($"Последняя цифра числа -> {lastNumber}");
}
else Console.WriteLine("Вы ввели не трёхзначное число!"); 