//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int num31=int.Parse(Console.ReadLine()!);
while(num31<100 || num31>999)
{
   Console.WriteLine("Введите трехзначное число");
   num31=int.Parse(Console.ReadLine()!); 
}
Console.WriteLine($"Вторая цифра числа - {num31%100/10}");

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число от 0 до 100 000");
int num41=int.Parse(Console.ReadLine()!);
while(num41>=100000 || num41<0)
{Console.WriteLine("Число больше 100 000 или меньше 0, введите положительное число меньше 100 000");
   num41=int.Parse(Console.ReadLine()!); }

if(num41>=0 && num41<100){Console.WriteLine("Третьей цифры нет");}
if(num41>=100 && num41<1000){Console.WriteLine($"Третья цифра числа {num41%10}");}
if(num41>=1000 && num41<10000){Console.WriteLine($"Третья цифра числа {num41%100/10}");}
if(num41>=10000 && num41<100000){Console.WriteLine($"Третья цифра числа {num41%1000/100}");}


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите номер дня недели от 1 до 7");
int num51=int.Parse(Console.ReadLine()!);
while(num51>7 || num51<1)
{Console.WriteLine("Введите число от 1 до 7");
   num51=int.Parse(Console.ReadLine()!); }
if(num51==6 || num51==7){Console.WriteLine("Это выходной");}
else {Console.WriteLine("Это не выходной");}