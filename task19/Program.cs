// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0, result = 0;
result = num % 100;
while (num > 100)
{
    temp = num % 10;
    result = result * 10 + temp;
    num = num / 10;
}
if(temp == result){
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
