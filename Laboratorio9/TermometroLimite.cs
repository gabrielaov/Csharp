namespace Laboratorio9
{
    public class TermometroLimite : Termometro
    {
        private double limiteSuperior;
        private bool disparadoEventoLimiteSuperior;
        public double LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }

        //CONSTRUTOR        
        public TermometroLimite(double ls)
        {
            limiteSuperior = ls;
            disparadoEventoLimiteSuperior = false;
        }

        public delegate void MeuDelegate(string msg);
        public event MeuDelegate LimiteSuperiorEvent;

        private void OnLimiteSuperiorEvent()
        {
        // verifica se a temperatura ultrapassou o limite e
        // Verifica se o evento já foi disparado, para não disparar continuamente.
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
            // verifica se há tratador
            if (LimiteSuperiorEvent != null)
            {
                LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!");
                disparadoEventoLimiteSuperior = true;
            }
        }

        public override void Aumentar(double quantia)
        {
            base.Aumentar(quantia);
            OnLimiteSuperiorEvent();
        }

        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            }
        }     
    }
}