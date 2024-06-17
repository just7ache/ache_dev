using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(3); //создаем стек с начальной емкостью на 3 элемента
            Console.WriteLine($"Количество элементов коллекции {stack.Count}");
            //добавляем новые элементы в стек
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);//на этом шаге емкость хранилища будет увеличена
            stack.Push(5);
            while (stack.Count > 0)
            {
                if (stack.Peek() == 3)
                {
                    Console.WriteLine($"Нашли в стеке значение 3. Всего элементов {stack.Count}");
                }
                Console.WriteLine($"Извлекли из стека значение {stack.Pop()}. Всего элементов {stack.Count}");
            }
        }
    }
}
