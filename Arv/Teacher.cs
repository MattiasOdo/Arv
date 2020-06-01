using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Teacher : Person
    {
        string type_of_work;
        string mentor_class;
        string school;
        int salary;

        public Teacher(string name, int age, string mentor_class, string type_of_work, int salary, string school) : base(name, age)
        {
            this.type_of_work = type_of_work;
            this.mentor_class = mentor_class;
            this.salary = salary;
            this.school = school;
        }

        public override void Print()
        {
            Console.WriteLine("Namn:" + name + " Ålder:" + age + " Typ av jobb:" + type_of_work + " i " + school + ". " + name + " är mentor till klassen " + mentor_class + ". " + name + " lön: " + salary+ " kr");
        }
    }
}
