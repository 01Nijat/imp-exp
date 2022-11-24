using System;

namespace implicit_explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kelvin celcius
            //Celsius celc = new Celsius(5);
            //Kelvin kelv = celc;
            //Console.WriteLine(kelv.Degree);

            #region kg to lbs
            //kilogram kilogram = new kilogram(60);
            //pound pound = kilogram;
            //Console.WriteLine(pound.lbs);
            //pound poun = new pound(132.277);// implicit usul
            //kilogram kilo = (kilogram)poun;  // explicit etmisik deye cast operatorunda qey etmliyik hansi ture cevireciyik,,
            //Console.WriteLine(kilo.kg);     // eslinde qisa olsun deye implicit daha meqsede uygundu.
            #endregion

            #endregion



        }
    }
    // Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var ve
    // Degree adli property-leri var.Celcius uchun implicit operatorunu yazmaginizi isteyirem.(0C= 273K)
    #region kelvin celcius
    //class Kelvin 
    //{
    //    public double Degree { get; set; }
    //    public Kelvin(double d)
    //    {
    //        Degree = d;
    //    }

    //    public static implicit operator Kelvin(Celsius v)
    //    {
    //        return new Kelvin(v.Degree + 273.5);
    //    } 
    //}

    //class Celsius
    //{
    //    public double Degree { get; set; }
    //    public Celsius(double c)
    //    {
    //        Degree = c;
    //    }


    //}
    #endregion

    #region kg to lbs
    // kg ve lbs convert etsin, implicit explicit usulu ile;
    //class kilogram
    //{
    //    public double kg { get; set; }
    //    public kilogram(double kg)
    //    {
    //        this.kg = kg;
    //    }
    //    public static explicit operator kilogram(pound pount)
    //    {
    //        return new kilogram(pount.lbs / 2.20462);
    //    }
    //}
    //class pound
    //{
    //    public double lbs { get; set; }
    //    public pound(double lbs)
    //    {
    //        this.lbs = lbs;
    //    }
    //    public static implicit operator pound(kilogram kilo)
    //    {
    //        return new pound(kilo.kg * 2.20462);
    //    }
    //}
    #endregion
}
