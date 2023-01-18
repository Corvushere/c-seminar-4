//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

/*
int a, b;
void Main( ) {
Console.WriteLine("Введите число 'A'");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'B'");
b = Convert.ToInt32(Console.ReadLine());}
Main( );
double square = Math.Pow(a, b);
Console.Write("Если возведём число " + a + " в степень " + b + ", получим: " + square);
*/   

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
452 -> 11//82 -> 10//9012 -> 12   */

/*
int x, y, i, count, sum;
Console.WriteLine("Введите число");
void countofnumb()  {
y = Convert.ToInt32(Console.ReadLine());
    x=y; count = 0;
    while (x != 0) {
    x /= 10;
    count++; }}
i=0; sum = 0;
void summ()  {
    while (i<count) {
    double sumy= Math.Pow(10, count-i-1);
    int sumx = Convert.ToInt32(sumy);
    sum = sum + y / sumx % 10 ;
    i++; }
Console.WriteLine("Сумма цифр числа " + y + " равна " + sum); }
countofnumb();
summ();
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.


static void Main()
        {
            int size = 8;
            int[] array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {   Console.WriteLine("Введите " + (i+1) + " число из 8");
                array[i] = Convert.ToInt32(Console.ReadLine());;
            }
            
            for (int i = 0; i < array.Length; i++)
            {   Console.Write(array[i] + " ");
            }}
        Main();
        
