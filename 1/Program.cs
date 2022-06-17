// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);
int n = paramInt;
int revers = 0;
int dig = 0;
int num = paramInt;
if (paramString.Length != 5)
Console.WriteLine("Введено неверное число!");

else
 while (num > 0)
 {
      dig = num % 10;
      revers = revers * 10 + dig;
      num = num / 10;
 }
if (n == revers)
Console.WriteLine($"{paramInt} палиндром");
else
Console.WriteLine($"{paramInt} не палиндром");