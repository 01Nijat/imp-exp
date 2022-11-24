using System;

namespace iearxia
{
    class Program
    {
        static void Main(string[] args)
        {
            // school mekteb = new school("Nicat", "Asgarov", 28);
            // mekteb.name = "Nicat";
            // mekteb.surname = "Asgarov";
            // mekteb.age = 28;
            // school mekteb2 = new school("Alay","Asgarov", 54);
            // mekteb2.name = "Alay";
            // mekteb2.surname = "Asgarov";
            // mekteb2.age = 54;
            //  Console.WriteLine($"{mekteb.Fullname()}, {mekteb.yas()}");
            // Console.WriteLine($"{mekteb2.Fullname()}, {mekteb2.yas()}");
            Muellim teacher1 = new Muellim("Irada","Asgarova", 51,"Mudur");
            Muellim teacher = new Muellim();
            teacher.name = "Alay";
            teacher.surname = "Asgarov";
            teacher.age = 54;
            teacher.vezife = "Muellim";

            Telebe student = new Telebe("Nicat","Asgarov", 28, "Telebe");
            Console.WriteLine($"{teacher1.Fullname()}");
            Console.WriteLine($"{teacher.Fullname()}");
            Console.WriteLine($"{student.Fullname()}");


        }
    }
}
