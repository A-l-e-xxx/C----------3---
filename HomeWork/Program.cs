/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число" );
int a = int.Parse(Console.ReadLine());

sqrCub(a);

void sqrCub(int a)
{

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(i * i * i);
}

}
*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53


//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Введите X координаты точки А: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y координаты точки A: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z координаты точки А: ");
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X координаты точки B: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y координаты точки B: ");
int yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z координаты точки B: ");
int zb = int.Parse(Console.ReadLine());

double result = Math.Sqrt( Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2) );

Console.WriteLine($"Расстояние {result}" );
*/

/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void palindrome(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - вроде палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - вроде не палиндром.");
}

if (number!.Length == 5){
  palindrome(number);
}
else Console.WriteLine($"Введите правильное число");
*/