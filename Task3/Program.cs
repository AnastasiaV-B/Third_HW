// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

// 1. Считать от пользователя N

int GetNumberByUser(string text)
{
    Console.Write(text + ":");
    return Convert.ToInt32(Console.ReadLine());
}
// 2. Создание массива

int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Метод получения кубов чисел

void GetCubes(int[] colNumbers)
{
    int count = colNumbers.Length;
    for(int i = 0; i < count; i++)
    {
        colNumbers[i] = i * i * i;
    }
}
// 4. Печать результата

string Print(int[] numbers)
{
string output = String.Empty;
int size = numbers.Length;

for(int i = 0; i < size; i++)
{
output = output + $"{i}^3 = {numbers[i]}\n";
}
return output;
}
