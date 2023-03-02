// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();
  return number;
}

void FillArray(double[] array, int n)
{
  Console.WriteLine($"Введите {n}-вещественных чисел массива:");
  for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine();
}

void PrintArray(double[] array)
{
  Console.Write("[ ");
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine("]");
}

double MaxElement(double[] array)
{
  double Max = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > Max)
      Max = array[i];
  }
  return Max;
}

double MinElement(double[] array)
{
  double Min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] < Min)
      Min = array[i];
  }
  return Min;
}



try
{
  int n = Welcome("Введите размер массива: \t");
  double[] array = new double[n];
  FillArray(array, n);
  PrintArray(array);
  Console.WriteLine($"\nМаксимальный элемент массива равно: - {MaxElement(array)}.");
  Console.WriteLine($"\nМинимальный элемент массива равно: - {MinElement(array)}.");
  double Diff = MaxElement(array) - MinElement(array);
  Console.WriteLine($"\nРазница между максимальным и минимальным элементом массива равно: - {Diff}!");
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}