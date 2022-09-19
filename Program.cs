//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* Console.WriteLine("Введите пятизначное число");
int a1 = int.Parse(Console.ReadLine());
a1 = Math.Abs(a1);
if (a1 <= 100000 && a1 >= 9999)
{
int a2 = (a1 / 1) % 10;
int a3 = (a1 / 10) % 10;
int a4 = (a1 / 1000) % 10;
int a5 = (a1 / 10000) % 10;
if (a2 == a5 && a3 == a4)
{
    Console.WriteLine($"{a1} : является палиндромом");
}
else
{
    Console.WriteLine($"{a1} : Не является палиндромом");
}
}
else
{
     Console.WriteLine($"{a1} : не является пятизначным числом");   
} */


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/* Console.WriteLine("Введите координаты X1:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y1:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z1:");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты X2:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y2:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z2:");
int z2 = int.Parse(Console.ReadLine());

Console.Write($"Расстояние между точками: ");
Console.Write(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2))); */


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* Console.WriteLine("Введите число:");
int a1 = int.Parse(Console.ReadLine());

for (int a2 = 1; a2 <= a1; a2++)
{
    Console.WriteLine($"{a2} x {a2} x {a2} = {Math.Pow(a2, 3)}");
} */