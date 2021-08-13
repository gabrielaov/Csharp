using System;

class ContaCorrente{
    private decimal saldo;
    private DateTime dataCriacao = DateTime.Now;
    private string nomeTitular;
    private decimal saldoMedio;
    private int cont;
    
    public void Depositar(decimal val){
        saldo = saldo + val;
        cont++;
        saldoMedio = saldo / cont;
        Console.WriteLine("Déposito de " + val);
    }

    public void Sacar(decimal val){
        saldo = saldo - val;
        cont++;
        saldoMedio = saldo / cont;
        Console.WriteLine("Saque de " + val);
    }

    public decimal Saldo{
        get => saldo;    
    }

    public DateTime Data{
        get => dataCriacao;
    }

    public string Nome{
        get => nomeTitular;
    }

    public decimal Media{
        get => saldoMedio;
    }
    
    //CONSTRUTOR
    public ContaCorrente(decimal val, string nome){
        saldo = val;
        nomeTitular = nome;
    }

}