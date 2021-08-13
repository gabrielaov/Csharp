using System;
using System.Drawing;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(2, 3, 4);
            Console.WriteLine(c1.ToString());

            CirculoColorido c3 = new CirculoColorido();
            Console.WriteLine(c3);

            Circulo c4 = new CirculoColorido();
            Console.WriteLine(c4);

            CirculoColorido c5 = new CirculoColorido();
            c5.CentroX = 5;
            c5.CentroY = 10;
            c5.Cor = "rosa";

            Console.WriteLine(c5.ToString());

            CirculoColoridoPreenchido c6 = new CirculoColoridoPreenchido();
            c6.CentroX = 7;
            c6.CentroY = 2;
            c6.Raio = 5;
            c6.Cor = "azul";
            c6.CorPreenchimento = Color.AliceBlue;

            Console.WriteLine(c6.ToString());

            
            Circulo[] circulos =  new Circulo[3];
            circulos[0] = new Circulo(2, 3, 4);
            circulos[1] = new CirculoColorido();
            circulos[2] = new CirculoColoridoPreenchido();

            foreach (var item in circulos)
            {
                Console.WriteLine(item);
            }

        }
    }
}
