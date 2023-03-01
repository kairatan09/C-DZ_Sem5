// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();
  return number;
}

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-99, 100);
}

void SumOddPos(int[] array)
{
  int Sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 == 1)
      Sum += array[i];
  }
  Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях в массиве равно - {Sum}!");
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
  SumOddPos(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}