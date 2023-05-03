// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0, count = 0;
if(num > 10000 && num < 100000)
{   
    count = num % 100;
    while(num > 100)
{
    num/=10;
}
  temp = num/10;
  num %= 10;
  temp = num * 10 + temp;
  if(temp == count)
{
    Console.WriteLine("да");
}
  else Console.WriteLine("нет");
}