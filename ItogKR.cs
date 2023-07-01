// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна
// 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
public static class Program
{
    public static void Main()
    {
        // Завдаём исходный массив, а также заготавливаем итоговый массив пока с одним пустым элементом
        string[] rowArray = new [] {“Hello”, “2”, “world”, “:-)”, “1234”, “1567”, “-2”, “computer science”, “Russia”, “Denmark”, “Kazan”};
        string[] itogArray = new [] {""};

        int k = 3; // критерий сравнения (наибольшая длина элемента для внесения его в итоговый массив)
        int j = 0; // номер элемента итогового массива

        for(int i = 0; i < rowArray.Length; i++) // тут длина массива
        {
            if(rowArray[i].Length <= k) // тут длина элемента
            {
                itogArray[j] = rowArray[i]; // вносим элемент i исходного массива в итоговый массив под индексом j
                j++; // следующий индекс итогового массива
                Array.Resize(ref itogArray, j + 1); // Увеличение размера итогового массива
            }
        }

        // выводим исходный массив
        Console.Clear();
        System.Console.WriteLine("Исходный массив:");
        for(int i = 0; i < rowArray.Length; i++)
            System.Console.Write($"{rowArray[i]}, ");
        System.Console.WriteLine("\n");

        string st = new String('=', 30); // разделительная строка из 30 знаков равенства, для красоты
        System.Console.WriteLine(st);

        // вывод итогового массива
        System.Console.WriteLine("\nИтоговый массив:\n");
        for(int i = 0; i < itogArray.Length; i++)
            System.Console.Write($"{itogArray[i]}, ");
        }
    }
}
