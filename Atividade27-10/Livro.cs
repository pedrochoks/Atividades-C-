namespace Atividade27_10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        // {
        //     get
        //     {
        //         return AnoPublicacao;
        //     }
        //     set
        //     {
        //         if (value > 10)
        //         {
        //             AnoPublicacao = value;
        //         }

        //         else
        //         {
        //             Console.WriteLine("Erro! Ano de publicacao e invalido");
        //         }
        //     }
        // }

        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; }

        //*Construtor
        //* eh um metodo especial, usado para inicializar o estado do objeto.

        public Livro(string tituloConstrutor, string autorConstrutor, int anoConstrutor, double precoConstrutor)
        {
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoConstrutor;
            Preco = precoConstrutor;

            // Definindo valor inicial como True
            EstaDisponivel = true;

            Console.WriteLine($"Novo Livro: {tituloConstrutor} criado e disponivel");
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("***DETALHES DO LIVRO***");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublicacao}");
            Console.WriteLine($"Preco: {Preco:F2}"); //F2 formata com 2 casas decimais

            if (EstaDisponivel)
            {
                Console.WriteLine("Status: Disponivel para Emprestimo");
            }
            else
            {
                Console.WriteLine("Status: Emprestado! (Indisponivel)");
            }
        }

        public void Emprestar()
        {
            if (EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine($"O Livro {Titulo} foi emprestado");
            }
            else
            {
                Console.WriteLine($"O livro: {Titulo} ja esta emprestado.");
            }
        }
    }
}