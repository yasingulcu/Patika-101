using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("****** Implicit Conversion *********** ");

            byte a=5;
            sbyte b=30;
            short c=10;

            int d=a+b+c;
            Console.WriteLine("d:"+d);

            long h=d;
            Console.WriteLine("h:"+h);

            float i=h;
            Console.WriteLine("i:"+i);

            string e="yasin";
            char f='k';
            object g=e+f+d;
            Console.WriteLine("g:"+g);

            //Explicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("****** Explicit Conversion *********** ");
            
            int x=4;
            byte y=(byte)x;
            Console.WriteLine("y "+y);

            float z=10.3f;
            byte t=(byte)z;
            Console.WriteLine("t "+t);

        }
    }
}
