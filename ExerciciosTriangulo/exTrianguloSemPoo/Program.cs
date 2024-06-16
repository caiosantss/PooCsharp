using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ex01SemPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double Xa, Xb, Xc, Ya, Yb, Yc;
            Xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p; 
            p = (Xa + Xb + Xc) / 2;
            double areaX, areaY;
            areaX = Math.Sqrt(p * (p - Xa) * (p - Xb) * (p - Xc));
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p = (Ya + Yb + Yc) / 2;
            areaY = Math.Sqrt(p * (p - Ya) * (p - Yb) * (p - Yc));

            Console.WriteLine($"Area do triangulo X: {areaX:F2}");
            Console.WriteLine($"Area do triangulo Y: {areaY:F2}");

            if (areaX > areaY)
            {
                Console.WriteLine($"Maior area:{areaX}");
            }
            else
            {
                Console.WriteLine($"Maior area:{areaY}");
            }

            Console.ReadLine(); 



        }
    }
}
