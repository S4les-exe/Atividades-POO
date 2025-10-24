namespace Exercicio_2_ClasseAbsrtata;

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo { Largura = 5, Altura = 3};
        Circulo c = new Circulo { Raio = 3};
        //da erro - nao podemos instanciar classe abstrata 
        //Forma f = new Forma {}; 
        //f.MostraTipo();

        r.MostrarTipo();
        Console.WriteLine($"Area do Retangulo : {r.CalcularArea()}");

        c.MostrarTipo();
        Console.WriteLine($"Area do Circulo : {c.CalcularArea()}");
    }
}
