using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        //static void Bubblesort(List<Person> sortclass)
        //{
        //    bool listsorted = false;
        //    while (listsorted == false)
        //    {

        //        listsorted = true;
        //        for (int i = 0; i < sortclass.Count - 1; i++)
        //        {
        //            if (sortclass[i] > sortclass[i + 1])
        //            {
        //                Person temp = sortclass[i];
        //                sortclass[i] = sortclass[i + 1];
        //                sortclass[i + 1] = temp;
        //                listsorted = false;
        //            }
        //        }
        //    }
        //}
        static int LSearch(List<Person> people, string name)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Name == name)
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Student("Mattias", 18, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Benjamin", 17, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Mohammad", 17, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Mohammed", 17, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Maya", 17, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Oskar", 17, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Andreas", 17, "Tycho Braheskolan", "TTE2A"));
            people.Add(new Student("Amelie", 17, "Tycho Braheskolan", "TTE2C"));
            people.Add(new Student("Emiliano", 17, "Tycho Braheskolan", "TTE2C"));
            people.Add(new Student("Johanna", 18, "Tycho Braheskolan", "TTE2B"));
            people.Add(new Student("Mert", 17, "Tycho Braheskolan", "TTE2C"));
            people.Add(new Student("Oliver", 17, "Tycho Braheskolan", "TTE2B"));
            people.Add(new Student("Olof", 17, "Tycho Braheskolan", "TTE2C"));
            people.Add(new Student("Simon", 17, "Tycho Braheskolan", "TTE2C"));
            people.Add(new Teacher("Jonas", 29, "TTE2C", "Lärare", 35000, "Tycho Braheskolan"));
            Console.WriteLine("Välkommen ti Info och Media klassen! Vill du komma in? (Ja/Nej)");
            string choice = Console.ReadLine();
            while(choice == "Ja")
            {
                Console.WriteLine("Vill du söka efter någon i Info och Media klassen eller vill du se hela klassen? (Söka/Klassen)");
                string choice2 = Console.ReadLine();
                if (choice2 == "Klassen")
                {
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("*** ALLA PERSONER I INFO OCH MEDIA KLASSEN ***");
                    Console.WriteLine("");
                    foreach (Person p in people)
                    {
                        p.Print();
                    }
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("*** ALLA ELEVER I INFO OCH MEDIA KLASSEN ***");
                    Console.WriteLine("");
                    foreach (Student s in people.OfType<Student>())
                    {
                        s.Print();
                    }
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("*** ALLA LÄRARE I INFO OCH MEDIA KLASSEN ***");
                    Console.WriteLine("");
                    foreach (Teacher t in people.OfType<Teacher>())
                    {
                        t.Print();
                    }
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("");


                    

                }
                while (choice2 == "Söka")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vem vill du söka efter?");
                    string find = Console.ReadLine();
                    int indexofvalue = LSearch(people, find);

                    if (indexofvalue == -1)
                    {
                        Console.WriteLine(find + " finns inte i listan");
                    }
                    else
                    {
                        Console.WriteLine(find + " ligger på plats: " + indexofvalue); Console.WriteLine("");
                        Console.WriteLine("Info om " + find);
                        Console.WriteLine("");
                        people[indexofvalue].Print();
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Vill du söka efter någon igen? (Söka/Nej)");
                    choice2 = Console.ReadLine();


                }
                Console.WriteLine("Vill du fortsätta? (Ja/Nej)");
                choice = Console.ReadLine();
            }
        }
    }
}
