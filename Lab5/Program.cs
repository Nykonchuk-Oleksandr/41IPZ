using System;
using System.Collections.Generic;
using System.Linq;

namespace MathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 5. Створення колекцій
                List<double> numbers = new List<double> { 10, 20, 15, 30, 25, 5 };
                Dictionary<string, double> results = new Dictionary<string, double>();
                Queue<double> operationHistory = new Queue<double>();

                Console.WriteLine("Математичний калькулятор");
                Console.WriteLine("Початкові числа: " + string.Join(", ", numbers));

                // 6. Методи розширення вибірки даних (3)
                var positiveNumbers = numbers.Where(n => n > 0);
                var evenNumbers = numbers.Select(n => n * 2);
                var numbersAboveAverage = numbers.TakeWhile(n => n > numbers.Average());

                // 7. Методи розширення зміни порядку даних (3)
                var sortedNumbers = numbers.OrderBy(n => n);
               
                var sortedDescending = numbers.OrderByDescending(n => n);

                // 8. Методи розширення вибірки даних (2)
                var firstThree = numbers.Take(3);
                var filteredSquares = numbers.Select(n => n * n).Where(n => n > 100);

                // 9. Метод розширення управління запитами (1)
                var deferredQuery = numbers.Where(n => n > 15).AsQueryable();

                // Виведення результатів LINQ
                Console.WriteLine("Числа > 0: " + string.Join(", ", positiveNumbers));
                Console.WriteLine("Подвоєні числа: " + string.Join(", ", evenNumbers));
                Console.WriteLine("Числа вище середнього: " + string.Join(", ", numbersAboveAverage));
                Console.WriteLine("Відсортовані числа: " + string.Join(", ", sortedNumbers));
              
                Console.WriteLine("Сортування за спаданням: " + string.Join(", ", sortedDescending));
                Console.WriteLine("Перші три числа: " + string.Join(", ", firstThree));
                Console.WriteLine("Квадрати чисел > 100: " + string.Join(", ", filteredSquares));
                Console.WriteLine("Відкладений запит (>15): " + string.Join(", ", deferredQuery));

                // Приклади математичних операцій
                double sum = numbers.Sum();
                double average = numbers.Average();
                double max = numbers.Max();

                // Збереження результатів
                results.Add("Сума", sum);
                results.Add("Середнє", average);
                results.Add("Максимум", max);

                // Додавання до історії операцій
                operationHistory.Enqueue(sum);
                operationHistory.Enqueue(average);
                operationHistory.Enqueue(max);

                // Виведення результатів
                Console.WriteLine("\nРезультати обчислень:");
                foreach (var result in results)
                {
                    Console.WriteLine($"{result.Key}: {result.Value}");
                }

                Console.WriteLine("\nІсторія операцій:");
                while (operationHistory.Count > 0)
                {
                    Console.WriteLine(operationHistory.Dequeue());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка: " + ex.Message);
            }
        }
    }
}
