using System;
using System.Collections.Generic;
namespace Laboratorio7

{
    public class Pessoa : IComparable<Pessoa>
    {
        public string nome {get; set; }
        public int idade {get; set; }

        public int CompareTo(Pessoa other)
        {
            if (nome.CompareTo(other.nome) == 0)
            {
                return idade.CompareTo(other.idade);
            }
            else
            {
                return nome.CompareTo(other.nome);
            }
                
        }

    }
        public class PessoaComparadorIdade : IComparer<Pessoa>
        {
            public int Compare(Pessoa x, Pessoa y)
            {
                return x.idade.CompareTo(y.idade);
            }
        }
    }
