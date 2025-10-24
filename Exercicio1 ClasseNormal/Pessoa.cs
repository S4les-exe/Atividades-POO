namespace Atividade_POO
{
    public class Pessoa
    {
        public string Nome;
        public int Idade; 

        // virtual - vamos utilizar o metedo em outra classe, podendo sobrescrever 
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome eh {Nome} e tenho {Idade} anos");
        }
    }
}