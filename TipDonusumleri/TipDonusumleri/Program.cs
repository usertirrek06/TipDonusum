using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float f = h;
            Console.WriteLine(f);

            string name = "Tarik";
            char n = 'c';
            object g = name + n;
            Console.WriteLine(g);

            //Explicit Conversion
            int z = 23;
            byte y = (byte)z;
            Console.WriteLine(y);
            var yy = Convert.ToString(y);
            Console.WriteLine(yy);

        }
    }
}
