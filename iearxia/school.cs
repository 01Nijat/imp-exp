using System;
using System.Collections.Generic;
using System.Text;

namespace iearxia
{
   public class school
    {   
       public string name;
       public string surname;
       public int age;
        public string vezife;
        public school()
        {

        }
        //public school(string v,string n, string s, int a) 
        //{
        //    name = n;
        //    surname = s;
        //    age = a;
        //    vezife = v;
        //}
        public string Ad()
        {
            return name;
        }
        public string soyadi()
        {
            return surname;
        }
        public int yas()
        {
            return age;
        }
        public string mission()
        {
            return vezife;
        }
        public string Fullname()
        {
            return $"{name} {surname} {age} {vezife}";
        }
    }
}
