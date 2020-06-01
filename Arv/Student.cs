using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Student : Person
    {
        string Class;
        string School;
        

        public Student(string name, int age, string School, string Class) : base(name, age)
        {
            this.School = School;
            this.Class = Class;
        }

        public override void Print()
        {
            Console.WriteLine("Namn:" + name + " Ålder:" + age + " Skola:" + School + " Klass:" + Class);
        }

    }
}
