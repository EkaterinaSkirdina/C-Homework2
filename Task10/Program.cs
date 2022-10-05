/*Задача 10. Напишите программу, которая на вход принимает трехзначное число, 
и на выходе показывает вторую цифру этого числа.*/

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num/10%10;

Console.WriteLine(a);

