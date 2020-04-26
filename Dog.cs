using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPAMAutoLab2
{
    [My(Name = "Rex")]
    class Dog : AnimalInter
    {
        readonly int count = 0;
        public int lives = 1;
        public String Name;

        
        public Dog(int count)
        {
            this.count = count;
        }

        
        public void DogName()
        {
            var type = this.GetType();         
            var attributeValue = Attribute.GetCustomAttribute(type, typeof(MyAttribute)) as MyAttribute;               
            this.Name = attributeValue.Name;
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
