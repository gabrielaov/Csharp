using System;
using System.Collections.Generic;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] nomes = {"Julio", "Lucia", "Daniel", "João"};

            Console.WriteLine("Nomes: ");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Array.Sort(nomes);

            Console.WriteLine("Nomes ordenados: ");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            */

        List<Pessoa> pessoas = new List<Pessoa>(){
            new Pessoa {nome = "Julio", idade = 30},
            new Pessoa {nome = "Gabriela", idade = 22},
            new Pessoa {nome = "Gabriela", idade = 20},
            new Pessoa {nome = "Eder", idade = 34}
        };
        Console.WriteLine("Pessoas: ");
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa.nome + " " + pessoa.idade);
        }

        //pessoas.Sort();

        //pessoas.Sort(new PessoaComparadorIdade());

        //pessoas.Sort((p1, p2) => p1.nome.CompareTo(p2.nome));
        pessoas.Sort((n1, n2) => n1.idade.CompareTo(n2.idade));

        Console.WriteLine("Pessoas ordenadas ");
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa.nome + " " + pessoa.idade);
        }

        Console.WriteLine(pessoas.Exists(p => p.nome == "Eder"));

        }
    }
}
