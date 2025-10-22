namespace Atividade_POO
{
    public class Pessoa
    {
        public String Nome;
        public int Idade;

    //* virtual - vamos utilizar o metodo em outra classe, podendo sobrescrever
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome} e tenho {Idade} anos.");
        }
    }
}