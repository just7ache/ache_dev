using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstavkiSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 0, -4, 3, 1, -2, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                int current_elem = array[i];
                int prev_elem = i - 1;

                while (prev_elem >= 0 && array[prev_elem] > current_elem)
                {
                    array[prev_elem + 1] = array[prev_elem];
                    array[prev_elem] = current_elem;
                    prev_elem--;
                }
            }

            Console.WriteLine("Сортировка вставками");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
