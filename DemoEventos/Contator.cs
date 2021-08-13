using System;
namespace DemoEventos

{
    public class Contador
    {
        public event EventHandler LimiteAtingido;
        public int valor { get; private set; }
        private int valorLimite;

        public Contador(int vl)
        {
            this.valorLimite = vl;
        }
        public void Incrementar()
        {
            valor++;
            if (valor == valorLimite)
            {
                if (LimiteAtingido != null)
                {
                    LimiteAtingido(this, EventArgs.Empty);
                }
            }
        }
    }
}