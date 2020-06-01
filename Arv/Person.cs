using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Person : IComparable<Person>
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > -1)
                    this.age = value;
            }
        }
        public virtual void Print()
        {

        }

        public int CompareTo(Person other)
        {
            return name.CompareTo(other.name);
        }

        public static bool operator <(Person C1, Person C2)
        {
            return (C1.name < C2.name);
        }
        public static bool operator >(Person C1, Person C2)
        {
            return (C1.name < C2.name);
        }
        public static bool operator ==(Person C1, Person C2)
        {
            return (C1.name < C2.name);
        }
        public static bool operator !=(Person C1, Person C2)
        {
            return (C1.name < C2.name);
        }
        public static bool operator <=(Person C1, Person C2)
        {
            return (C1.name < C2.name;
        }
        public static bool operator >=(Person C1, Person C2)
        {
            return (C1.name < C2.name);
        }


    }
}
