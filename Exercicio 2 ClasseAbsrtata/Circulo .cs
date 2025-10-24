namespace Exercicio_2_ClasseAbsrtata
{
    public class Circulo : Forma
    {
        public double Raio; 
        public override double CalcularArea() => Math.PI * Raio * Raio; 
    }
}