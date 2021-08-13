using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente(340, "Gabriela");
            Console.WriteLine("Nome titular: " + minhaConta.Nome);
            Console.WriteLine("Data de criação conta: " + minhaConta.Data);
            Console.WriteLine("Saldo atual: " + minhaConta.Saldo + "\nSaldo médio: " + minhaConta.Media);
            minhaConta.Depositar(100);
            Console.WriteLine("Saldo atual: " + minhaConta.Saldo + "\nSaldo médio: " + minhaConta.Media);
            minhaConta.Sacar(50);
            Console.WriteLine("Saldo atual: " + minhaConta.Saldo + "\nSaldo médio: " + minhaConta.Media);

            ContaCorrente minhaConta2 = new ContaCorrente(0, "Ederson");
            Console.WriteLine("Nome titular: " + minhaConta2.Nome);
            Console.WriteLine("Data de criação conta: " + minhaConta2.Data);

            Console.WriteLine("Saldo atual: " + minhaConta2.Saldo + "\nSaldo médio: " + minhaConta2.Media);

            minhaConta2.Depositar(10);
            minhaConta2.Depositar(100);
            minhaConta2.Depositar(200);
            minhaConta2.Depositar(90);
            minhaConta2.Sacar(100);

            Console.WriteLine("Saldo atual: " + minhaConta2.Saldo + "\nSaldo médio: " + minhaConta2.Media);
        }
    }
}
