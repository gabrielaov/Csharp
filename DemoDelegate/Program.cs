using System;

namespace DemoDelegate
{
    public delegate void ReferenciaMetodoVoid();

    public delegate void ReferenciaMetodoVoidComParametro(int x);
    class Program
    {
        static void Main(string[] args)
        {
            ReferenciaMetodoVoid refm = AloMundo;
            refm();
            ReferenciaMetodoVoidComParametro refm2 = AloNumero;
            refm2(10);
            ReferenciaMetodoVoid refm3 = () => Console.WriteLine("Alo Mundo");
            ReferenciaMetodoVoidComParametro refm4 = (int x) => Console.WriteLine("Alo {0}", x);
            
            int resultado = FazAlgo((x, y) => x * y, 5);
            Console.WriteLine(resultado);

            var acoisa = ConstroiMetodo(5);
            int resultado2 = acoisa(10);
            Console.WriteLine(resultado2);
        }

        static void AloMundo()
        {
            Console.WriteLine("Alo mundo");
        }
        
        static void AloNumero(int x)
        {
            Console.WriteLine("Alo {0}", x);
        }

        static int FazAlgo(Func<int, int, int> f, int x)
        {
            return f(x, x);
        }

        static Func<int, int> ConstroiMetodo (int x)
        {
            return (x) => x + 1;
        }

    }
}
