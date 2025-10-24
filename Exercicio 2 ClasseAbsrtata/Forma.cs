namespace Exercicio_2_ClasseAbsrtata
{
    public abstract class Forma
    {
        //metodo abstrato obriga a classe filha a implementar o metodo e sobrescrever (override)
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geometrica.");
        }
    }
}