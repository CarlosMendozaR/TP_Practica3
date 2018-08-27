using System;

namespace Polimorfismo
{
    class Television:DispositivosAudio
    {
        public override void GrabarSonido()
        {
            Console.WriteLine("Este dispostivo no puede grabar sonidos");
        }
    }
}
