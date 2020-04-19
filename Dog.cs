using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMAutoLab2
{
    class Dog : AnimalInter
    {
        int count = 0;
        public Dog(int count)
        {
            this.count = count;
        }
        public int countFoot()
        {
            return count;
        }

        public string Walking(string text)
        {
            return text + "бегает и лает";
        }

        public string Say()
        {
            return "Лает";
        }

    }
}
