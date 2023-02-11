/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.Write("Insert 5-digit number: ");
int number = int.Parse(Console.ReadLine()); 
    int A = number / 10000 % 10;
    int B = number / 1000 % 10;
    int C = number / 10 % 10;
    int D = number % 10;
    int E = number / 10000;
        if (E < 1 || E > 9){
            Console.WriteLine(number + " -> " + "Not 5-digit number");
            }
            else if  (A == D && B == C){
            Console.WriteLine(number + " -> Yes, this is palindrom");
            }
            else{
            Console.WriteLine(number + " -> No, this is not palindrom");
            }
           

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Enter X1: ");

int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter Y1: ");

int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z1: ");

int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X2: ");

int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y2: ");

int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z2: ");

int Z2 = int.Parse(Console.ReadLine()!);

double X = Math.Abs(X1 - X2);

double Y = Math.Abs(Y1 - Y2);

double Z = Math.Abs(Z1 - Z2);

double XX = Math.Pow(X, 2);

double YY = Math.Pow(Y, 2);

double ZZ = Math.Pow(Z, 2);

double result = Math.Sqrt(XX + YY+ ZZ);

Console.Write(result);



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int count = 1;
Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());

while (count <= a)
{
Console.Write(a * a * a);
if (count != a)
{
Console.Write(", ");
}
count++;
}