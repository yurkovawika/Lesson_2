// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите  число  > ");
string array = Console.ReadLine();
int length = array.Length;  //длина строки.

if (length < 3)
{
   Console.WriteLine("Третьей цифры нет");
}
else
{
   Console.WriteLine($"Третья цифра -> {array[2]}");
}