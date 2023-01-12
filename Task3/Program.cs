// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

void doube(int size)
{
    for(int i = 1; i <= size; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
}
int n = System.Convert.ToInt32(Console.ReadLine());
doube(n);