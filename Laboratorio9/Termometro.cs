namespace Laboratorio9
{ 
    public class Termometro
    {
        private double valor;
        
        public double Temperatura
        {
            get { return valor; }
            set { valor = value; }
        }

        //CONSTRUTOR
        public Termometro()
        {
            valor = 0.0;
        }

        virtual public void Aumentar(double quantia)
        {
            valor += quantia;
        }

        virtual public void Diminuir(double quantia)
        {
            valor -= quantia;
        }

        override public string ToString()
        {
            return "Temperatura atual: " + valor.ToString();
        }
    }
}