using NLog;
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
        [My(Name = "Rex")]
        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            
            Cat cat = new Cat();
            Dog dog = new Dog(4);

            Console.WriteLine(dog.Name);
            Cat catWoman = new Cat
            {
                lives = 5
            };
            log.Debug("Обьекты созданы");

            Console.WriteLine(cat.countFoot());
            Console.WriteLine(cat.Say());
            log.Debug("Обьект Кот выведен в консоль");

            Console.WriteLine();
            dog.DogName();
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Say());
            Console.WriteLine(dog.countFoot());
            log.Debug("Обьект Собака выведен в консоль");

            List<object> list = new List<object>
            {
                cat.lives,
                dog.lives,
                catWoman.lives
            };

            list.Sort();

            foreach (int x in list)
            {
                Console.Write(x + " ");
            }

            try
            {
                Console.WriteLine();
                Console.WriteLine("Введите число больше 2, что бы завершить");
                int a = Int32.Parse(Console.ReadLine());
                if (a <= 2)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                log.Debug("Вылетело исключение. Следуйте правилам на экране" + e);
                Console.WriteLine("Ввели неверное число");
            }
        }
    }
}
