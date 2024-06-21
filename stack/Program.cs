using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Просто элементы в статичном стеке:");
            var employees = new List<string> { "Tom", "Sam", "Bob" };
            Stack<string> people = new Stack<string>(employees);
            foreach (var person in people) Console.WriteLine(person);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Кол-во элементов в статичном стеке:");

            Console.WriteLine(people.Count);

            Console.WriteLine("------------------------------------");

            var people0 = new Stack<string>();
            people0.Push("Tom");
            // people = { Tom }
            people0.Push("Sam");
            // people = { Sam, Tom }
            people0.Push("Bob");
            // people = { Bob, Sam, Tom }

            Console.WriteLine("Первый элемент динамического стека:");

            // получаем первый элемент стека без его удаления 
            string headPerson = people0.Peek();
            Console.WriteLine(headPerson);  // Bob

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Просто элементы динамического стека:");

            string person1 = people0.Pop();
            // people = { Sam, Tom }
            Console.WriteLine(person1);  // Bob

            string person2 = people0.Pop();
            // people = { Tom }
            Console.WriteLine(person2);  // Sam

            string person3 = people0.Pop();
            // people = { }
            Console.WriteLine(person3);  // Tom

            Console.WriteLine("------------------------------------");

            Console.ReadLine();
        }
    }
}
