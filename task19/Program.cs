// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0, result = 0;
if(num < 100000 && num > 10000){
result = num % 100;
while(num > 100){
    num/=10;
}
temp = num/10;
num %= 10;
temp = num * 10 + temp;
if(temp == result){
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
}