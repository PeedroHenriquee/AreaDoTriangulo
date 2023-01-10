using System;
using System.Globalization;

namespace AreaDoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do lado X: ");

            double Xa, Xb, Xc, Ya, Yb, Yc;

            Xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do lado X: ");
            Ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double px = (Xa + Xb + Xc) / 2.0;
            double areaX = Math.Sqrt(px*(px - Xa) * (px - Xb) * (px - Xc));

            double py = (Ya + Yb + Yc) / 2.0;
            double area = Math.Sqrt(py * (py - Ya) * (py - Yb) * (py - Yc));

            Console.WriteLine($"A aréa de x Eh: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A aréa de y Eh: {area.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > area)
            {
                Console.WriteLine("Maior aréa eh area X");
            }
            else
            {
                Console.WriteLine("Maior aréa eh area Y");
            }

        }
        
    }
}
