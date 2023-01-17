//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B


int a, b;
Console.WriteLine("Введите число 'A'");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'B'");
b = Convert.ToInt32(Console.ReadLine());
    void square {
    double square = Math.Pow(a, b);}
Console.Write("Если возведём число 'А' в степень 'B', получим: " + square);