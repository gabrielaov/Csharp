using System.Drawing;

namespace Laboratorio4
{
    public class CirculoColoridoPreenchido : CirculoColorido {

        public Color CorPreenchimento {get; set;}

        public CirculoColoridoPreenchido(){
            CorPreenchimento = Color.Aqua;
        }

        public override string ToString()
        {
            return base.ToString() + ", Cor Preenchimento: " + CorPreenchimento;
        }
    }
}