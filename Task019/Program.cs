// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

int number = 0;
while (number < 10000 || number > 99999)
{
    Console.WriteLine("Введите пятизначное число");
    number = Convert.ToInt32(Console.ReadLine());
}

string numberString = Convert.ToString(number);

if (numberString[0] == numberString[4] && numberString[1] == numberString[3])
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}