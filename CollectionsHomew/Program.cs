using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsHomew
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 1, 32, 44, 68, 105, 99, 87, 12, 39};
            foreach(int number in numbers)
            {
                Console.Write(number + "  ");
            }
            int maxListElement = numbers.Max();
            int sum = 0;
            int index = 0;
            int secondMaxElement = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > secondMaxElement && numbers[i] < maxListElement)
                {
                    secondMaxElement = numbers[i];
                    index = i;
                }
                if(i % 2 == 0 && i != 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine("\nВторой максимальный элемент списка = " + secondMaxElement + " позиция в списке = " + index);
            Console.WriteLine("Сумма четных элементов = " + sum);
            Console.ReadKey();
        }
    }
}
