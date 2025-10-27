namespace Atividade_27._10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao{ get; set; }
        // { 
        //     get
        //     {
        //         return AnoPublicacao;
        //     }
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             AnoPublicacao = value; 
        //         }
        //         else 
        //         {
        //             Console.WriteLine("Erro! Ano de Publicacao eh invalido!");
        //         }
        //     }
        // }

        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; }
//---------------------------------------------------------------------------------------------------------------
        // CONSTRUTOR 
        // eh um metodo especial, usado para inicializar o objeto. 
        public Livro(string tituloConstrutor, string autorConstrutor, int anoConstrutor, double precoConstrutor) //regra ser o mesmo nome da classe 
        {
            //this.Titulo = titulo;
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoConstrutor;
            Preco = precoConstrutor;

            //Definindo valor inicial como true
            EstaDisponivel = true; 

            Console.WriteLine($"Novo Livro: {tituloConstrutor} criado e disponivel.");
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("*** DETALHES DO LIVRO ***");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublicacao}");
            Console.WriteLine($"Preco: {Preco:F2}"); //F2: Formata com duas casas decimais 

            if(EstaDisponivel)
            {
                Console.WriteLine("Status: Disponivel para Emprestimo");
            }
            else
            {
                Console.WriteLine("Status: Emprestado no momento!(indisponivel)");
            }
        }

        public void Emprestar()
        {
            if(EstaDisponivel)
            {
                EstaDisponivel = false; 
                Console.WriteLine($"O livro: {Titulo} foi Emprestado.");
            }
            else 
            {
                Console.WriteLine($"O livro: {Titulo} ja esta emprestado.");
            }
        }
    }
}