namespace Exercicio_2_ClasseAbsrtata
{
    public class Retangulo : Forma
    {
        public double Largura; 
        public double Altura; 

        public override double CalcularArea() => Largura * Altura; 
    }
}