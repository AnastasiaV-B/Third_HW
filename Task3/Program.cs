// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

// 1. Считать от пользователя N

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

// 2. Создание массива

void Cube(int[] cube)
{
  int counter = 1;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

// 3. Метод получения кубов чисел

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

// 4. Печать результата

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);