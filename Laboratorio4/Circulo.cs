namespace Laboratorio4
{
    public class Circulo{
        public double CentroX{get; set;}       
        public double CentroY{get; set;}  
        public double Raio {get; set;}     

        public Circulo(double x, double y, double z){
            CentroX = x;
            CentroY = y;
            Raio = z;
        } 


        public override string ToString(){
            return $"Centro: ({CentroX}, {CentroY}), Raio: {Raio}";
        }
    }
}