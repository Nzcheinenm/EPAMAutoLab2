using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMAutoLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog(4);
            Cat catWoman = new Cat();

            catWoman.lives = 5;

            Console.WriteLine(cat.countFoot());
            Console.WriteLine(cat.Say());

            Console.WriteLine(dog.Say());
            Console.WriteLine(dog.countFoot());

            List<object> list = new List<object>();

            list.Add(cat.lives);
            list.Add(dog.lives);
            list.Add(catWoman.lives);

            list.Sort();

            foreach (int x in list)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Введите любой символ, что бы завершить");
            String a = Console.ReadLine();
        }
    }
}
