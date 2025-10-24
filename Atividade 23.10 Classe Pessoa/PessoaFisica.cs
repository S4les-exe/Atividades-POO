namespace Atividade_23._10_Classe_Pessoa
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; } = string.Empty; 

        public DateTime DataNascimento { get; set; }

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa Fisica: {Nome}, CPF: {CPF} - pagando imposto...");
        }
    }
}