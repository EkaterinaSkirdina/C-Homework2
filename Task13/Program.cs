/* Напишите программу, которая выводит третью цифру заданного числа, 
или сообщает что третьей цифры нет.*/


Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string textNumber = Convert.ToString(number);

if (textNumber.Length > 2)
{
    Console.WriteLine("третья цифра -> " + textNumber[2]);
}
else
{
Console.WriteLine("третьей цифры нет");
}