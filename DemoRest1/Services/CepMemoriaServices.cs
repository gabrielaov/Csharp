using DemoRest1.Models;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace DemoRest1.Services
{
    public class CepMemoriaServices : ICepService
    {
        public readonly ConcurrentDictionary<string, ConsultaCep> _dados = 
        new ConcurrentDictionary<string, ConsultaCep>();

        public ConsultaCep ConsultaPorCep(string cep)
        {
            ConsultaCep resultado;
            _dados.TryGetValue(cep, out resultado);
            return resultado;
        }

        public IEnumerable<ConsultaCep> ConsultaTodos()
        {
            return _dados.Values;
        }

        public CepMemoriaServices()
        {
            _dados.TryAdd("92330220", new ConsultaCep{
                Logradouro = "Rua São Jeronimo",
                Bairro = "Mathias Velho",
                Cidade = "Canoas",
                Estado = "RS",
                Cep = "92330220"
            });

            _dados.TryAdd("92589620", new ConsultaCep{
                Logradouro = "Rua Jeronimo",
                Bairro = "Mathias",
                Cidade = "Canoas",
                Estado = "SC",
                Cep = "92589620"
            });
        }
    }   
}
