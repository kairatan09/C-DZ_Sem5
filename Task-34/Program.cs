// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}

void QuantityEven(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      count++;
  }
  Console.WriteLine();
  Console.WriteLine($"Количество чётных чисел в массиве равно - {count}!");
}

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}



try
{
  int n = Welcome("Введите размер массива: \t");
  int[] array = new int[n];
  FillArray(array);
  PrintArray(array);
  QuantityEven(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}