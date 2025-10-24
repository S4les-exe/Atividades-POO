namespace Atividade_23._10_Classe_Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; } = string.Empty;
        
        public string RazaoSocial { get; set; } = string.Empty; 

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa Juridica: {RazaoSocial}, CNPJ: {CNPJ} - Pagando imposto....");
        }
    }
}