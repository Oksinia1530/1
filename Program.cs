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