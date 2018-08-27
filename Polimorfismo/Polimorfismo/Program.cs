using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido, escoja su dispositivo de audio:\n1. Bocina\n2. Celular\n3. Computadora\n4. Megafono\n5. Silbato\n6. Telelevision");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Bocina miBocina = new Bocina();
                    break;
                case 2:
                    Celular miCelular = new Celular();
                    break;
                case 3:
                    Computadora miComputadora = new Computadora();
                    break;
                case 4:
                    Megafono miMegafono = new Megafono();
                    break;
                case 5:
                    Silbato miSilbato = new Silbato();
                    break;
                case 6:
                    Television miTelevision = new Television();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
