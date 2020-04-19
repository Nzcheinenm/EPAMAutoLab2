using System;
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

            Console.WriteLine(cat.countFoot());
            Console.WriteLine(cat.Say());

            Console.WriteLine(dog.Say());
            Console.WriteLine(dog.countFoot());

            Console.WriteLine("Введите любой символ, что бы завершить");
            String a = Console.ReadLine();
        }
    }
}
