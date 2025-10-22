namespace Atividade2_ClasseAbstrata
{
    //* abstract =
    public abstract class Forma
    {
        //* Metodo abstrato obriga a classe filha a implementar o metodo e sobrescrever (override)
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geometrica.");
        }
    }
}