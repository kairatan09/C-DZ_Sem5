// Задача 30. - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы с массивами использовать нельзя.


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

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}

int[] Sort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int MaxIndex = i;
    for (int CurrentIndex = i + 1; CurrentIndex < array.Length; CurrentIndex++)
    {
      if (array[CurrentIndex] > array[MaxIndex])
        MaxIndex = CurrentIndex;
    }
    //int temp = array[i];
    //array[i] = array[MaxIndex];
    //array[MaxIndex] = temp;
    (array[i], array[MaxIndex]) = (array[MaxIndex], array[i]);
  }
  return array;
}

int[] Rand(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    int n = new Random().Next(0, array.Length - 1);
    int MaxIndex = i;
    //int temp = array[i];
    //array[i] = array[n];
    //array[n] = temp;
    (array[i], array[n]) = (array[n], array[i]);
  }
  return array;
}



try
{
  int n = Welcome("Введите размер массива: \t");
  int[] array = new int[n];
  FillArray(array);
  Console.WriteLine("Массив заполненный случайными числами:");
  PrintArray(array);
  Console.WriteLine("\nОтсортированный массив от большего к меньшему:");
  PrintArray(Sort(array));
  Console.WriteLine("\nПеремешанный массив на основе случайности:");
  PrintArray(Rand(array));
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}