using System;

namespace Polimorfismo
{
    abstract class DispositivosAudio
    {
        public DispositivosAudio()
        {
            Informacion();
        }

        public virtual void EmitirSonido()
        {
            Console.WriteLine("Se ha emitido un sonido");
        }

        public virtual void GrabarSonido()
        {
            Console.WriteLine("Se ha grabado un sonido");
        }

        public virtual void Encender()
        {
            Console.WriteLine("Se ha encendido su dispositivo");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("Se ha apagado su dispositivo");
        }

        public void Informacion()
        {
            int opcion = 1;
            Encender();
            do
            {
                Console.WriteLine("Escriba 1 para emitir un sonido\nEscriba 2 para grabar un sonido\nEscriba 0 para apagar su dispositivo o salir");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        EmitirSonido();
                        break;
                    case 2:
                        GrabarSonido();
                        break;
                    case 0:
                        Apagar();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
