using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViborSort
{
    internal class Program
    {
        static void ViborSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел в массиве");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите элементы массива");
            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            ViborSort(array);
            Console.WriteLine("Сортировка выбором");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
