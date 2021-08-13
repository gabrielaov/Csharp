using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte b; 
            int i;
            long l;
            string strPrimeira = "Alo";
            string strSegunda = "Mundo";
            string strTerceira = strPrimeira + strSegunda;
            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho = " + cchTamanho.ToString();
            DateTime dt = new DateTime(2015, 04, 23);
            string strQuinta = dt.ToString();

            b = byte.MaxValue;
            i = int.MaxValue;
            l = long.MaxValue;


            Console.WriteLine("Valor máximo de byte: " + b);
            Console.WriteLine($"\nValor máximo de byte: {b}");
            Console.WriteLine("\nValor máximo de int: " + i);
            Console.WriteLine("\nValor máximo de long: " + l);
            Console.WriteLine("\n" + strTerceira);
            Console.WriteLine("\n" + strQuarta);
            Console.WriteLine(strTerceira.Substring(0, 5));
            Console.WriteLine(strQuinta);
            */     

            /*EXERCICIO 1

            float valor1;
            double valor2;
            decimal valor3;

            valor1 = float.MaxValue;
            valor2 = double.MaxValue;
            valor3 = decimal.MaxValue;

            Console.WriteLine("Valor máximo Float: " + valor1);
            Console.WriteLine("Valor máximo Double: " + valor2);
            Console.WriteLine("Valor máximo Decimal: " + valor3);
            */

            /*EXERCICIO 2
            string teste = "teste";
            string teste2 = "teste2";
            string teste3 = "teste3";

            string teste4 = String.Join(teste, teste2, teste3);

            Console.WriteLine(teste4);

            string testeTrim = "     Bom dia! Seja bem-vindo!   ";

            Console.WriteLine(testeTrim.Length);

            string teste5 = testeTrim.Trim();

            Console.WriteLine(teste5.Length + "" + teste5);

            */


            /*EXERCICIO 3
            DateTime dt = DateTime.Now;

            String ano = dt.Year.ToString();
            String mes = dt.Month.ToString();
            String dia = dt.Day.ToString();

            Console.WriteLine("ano: " + ano);
            Console.WriteLine("mes: "+ mes);
            Console.WriteLine("dia" + dia);

            */

            /*EXERCICIO 4
            int i = 10;
            float f = 0;
            f = i; //conversão implicita, sem perda de dados
            System.Console.WriteLine(f);
            f = 0.5f;
            i = (int) f; //conversão explicita, com perda de dados
            System.Console.WriteLine(i);

            */
            /*EXERCICIO 5
            string stringInteiro = "123456789";
            int valorStringInteiro = Convert.ToInt32(stringInteiro);
            Console.WriteLine(valorStringInteiro);
        

            Int64 valorInt64 = 123456789;
            int valorInt = Convert.ToInt32(valorInt64);
            Console.WriteLine(valorInt);

            */

            /*EXERCICIO 6
            string stringInteiro = "123456789";
            int valorStringInteiro;
            bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
            Console.WriteLine("Conversão efetuada: " + conversao1 + " Valor: " + valorStringInteiro);

            string stringInteiroGrande = "99999999999999999999999999999999999999999999";
            int valorStringInteiroGrande;
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
            Console.WriteLine("Conversão efetuada: " + conversao2 + " Valor: " + valorStringInteiroGrande);

            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
            Console.WriteLine("Conversão efetuada: " + conversao3 + " Valor: " + valorStringLetras);

            */

            /*EXERCICIO 7
            double valorFracionado = 4.7;
            int valorInteiro1 = (int) valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);

            Console.WriteLine("Conversao explicita = " + valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

            */

            /*EXERCICIO 8
            int x = 10;
            double y = 3.4;
            float z = (float)5.6;
            Console.WriteLine("{1} {0} {2}", x, y, z);

            */

            Teste t1 = new Teste();
            Console.Write(t1.str);
        }
    }
}
