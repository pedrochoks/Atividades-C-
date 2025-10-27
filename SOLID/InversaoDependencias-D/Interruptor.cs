namespace InversaoDependencias_D
{
    public class Interruptor
    {
        //Privada somente para leitura, variavel criada como dispositivo
        private readonly IDispositivo dispositivo;

        public Interruptor(IDispositivo dispositivo) // _dispositivo
        {
            //this.dispositivo para nao confundir as variaveis
            this.dispositivo = dispositivo;
        }

        public void Acionar() => dispositivo.Ligar();
    }
}   