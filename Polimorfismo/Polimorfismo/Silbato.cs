using System;

namespace Polimorfismo
{
    class Silbato:DispositivosAudio
    {
        public override void GrabarSonido()
        {
            Console.WriteLine("Este dispostivo no puede grabar sonidos");
        }

        public override void Encender()
        {
            Console.WriteLine("Este dispositivo no puede encenderse");
        }

        public override void Apagar()
        {
            Console.WriteLine("Este dispositivo no puede apagarse");
        }
    }
}
