using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMAutoLab2
{
    class Cat : AnimalInter
    {
        public int lives = 9;
        public int countFoot()
        {
            return 4;
        }

        public string Walking(string text)
        {
            return text + "ходит";
        }

        public String Say()
        {
            Console.WriteLine("Мяу");
            return "Мяукает";
        }
    }
}
