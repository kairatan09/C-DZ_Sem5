// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();
  return number;
}

// void FillArray(double[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-99, 100);
// }

void FillArray(int[] array, int n, int dot)
{
  Console.WriteLine($"\nВведите {n}-мерную координату точки {dot}:");
  for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}


try
{
  int n = Welcome("Введите размер массива: \t");
  double[] array = new double[n];
  FillArray(array);
  PrintArray(array);
  //SumOddPos(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}