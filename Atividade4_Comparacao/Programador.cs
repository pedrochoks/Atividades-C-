namespace Atividade4_Comparacao
{
    public class Programador : Funcionario, ITrabalhador 
    {
        public override void Trabalhar() => Console.WriteLine($"{Nome} esta programando...");
        public void ExecutarTarefa() => Console.WriteLine($"{Nome} concluiu una tarefa.");
        
    }
}