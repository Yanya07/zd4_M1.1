using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] numbers = new int[10];// Создаем массив из 10 целых чисел
            Random random = new Random();// Создаем экземпляр класса Random для генерации случайных чисел
            for (int i = 0; i < numbers.Length; i++)// Заполняем массив случайными числами от 1 до 100
            {
                numbers[i] = random.Next(1, 101); // Случайное число от 1 до 100
            }

            Console.WriteLine("Сгенерированный массив: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            int sum = 0;// Вычисляем сумму всех элементов массива
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Сумма всех элементов массива: {sum}");

            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
    }
}

