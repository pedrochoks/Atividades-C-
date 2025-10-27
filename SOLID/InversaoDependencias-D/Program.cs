namespace InversaoDependencias_D;

class Program
{
    static void Main(string[] args)
    {
        IDispositivo lampada = new Lampada();
        IDispositivo Ar = new ArCondicionado();

        Interruptor interruptor1 = new Interruptor(lampada);
        Interruptor interruptor2 = new Interruptor(Ar);

        interruptor1.Acionar();
        interruptor2.Acionar();
    }
}
