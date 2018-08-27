using System;

namespace Polimorfismo
{
    class Bocina:DispositivosAudio
    {
        public override void GrabarSonido()
        {
            Console.WriteLine("Este dispostivo no puede grabar sonidos");
        }
    }
}
