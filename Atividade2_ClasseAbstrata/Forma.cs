namespace Atividade2_ClasseAbstrata
{
    //* abstract
    public abstract class Forma
    {
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geometrica.");
        }
    }
}