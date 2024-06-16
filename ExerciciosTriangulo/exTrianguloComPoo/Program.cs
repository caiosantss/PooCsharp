using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex01ComPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criamos variaveis x e y do tipo TRIANGULO, logo uma classe pode ser considerada um tipo, assim como int, double...

            Triangulo x, y;

            //Não basta criar as variaveis, devemos instancia-las com NEW classe(), criando um OBJETO DA CLASSE.

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            //Para acessar um atributo usa-se variavel.ATRIBUTO
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Area triangulo X: {areaX.ToString(CultureInfo.InvariantCulture):f2}");
            Console.WriteLine($"Area triangulo Y: {areaY.ToString(CultureInfo.InvariantCulture):f2}");
            

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: Triangulo X");
            }
            else
            {
                Console.WriteLine("Maior area: Triangulo Y");
            }
            Console.ReadLine(); 

        }
    }
}
