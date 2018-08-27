using System;

namespace Polimorfismo
{
    class Megafono:DispositivosAudio
    {
        public override void GrabarSonido()
        {
            Console.WriteLine("Este dispostivo no puede grabar sonidos");
        }
    }
}
