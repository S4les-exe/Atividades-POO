namespace Atividade_POO
{
    public class Aluno : Pessoa   //Aluno herda de pessoa 
    {
        public string Curso; 

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o(a) aluno(a) {Nome}, tenho {Idade} anos e estudo {Curso}");
        }
    }
}
