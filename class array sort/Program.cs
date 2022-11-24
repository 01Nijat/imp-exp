using System;

namespace class_array_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Nicat", "Esgerov", 25000);
            Person p2 = new Person("Ferid", "Eliyev", 20000);
            Person p3 = new Person("Zakir", "Serdarov", 10000);
            Person p4 = new Person("Firudin", "Sabanov", 10500);
            Person p5 = new Person("Azer", "Veyselov", 1600);
            Person p6 = new Person("Timur", "Celalov", 2500);
            Person[] person = new Person[] { p1, p2, p3, p4, p5, p6 };
            Array.Sort(person);   // burda IComparable ile implement etmeliyik. person classini. error vermesin deye.
            foreach (var item in person)
            {
                Console.WriteLine($"{item.name} {item.maas}");
            }
            // Console.WriteLine(p1>p2);   // muqayise operatoru 
            // Console.WriteLine(p2>p3);




        }
    }

    class Person : IComparable
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int maas { get; set; }

        public Person(string name, string surname, int maas)
        {
            this.name = name;
            this.surname = surname;
            this.maas = maas;
        }

        public int CompareTo(object obj)
        {
            return ((Person)obj).maas.CompareTo(this.maas);
        }
        //public static bool operator >(Person p1, Person p2)
        //  {
        //      return p1.maas > p2.maas;
        //  }
        //  public static bool operator <(Person p1, Person p2)  //  Muqayise Operatorudur. bu cur yazilir.
        //  {
        //      return p1.maas < p2.maas;
        //  }


    }
}
