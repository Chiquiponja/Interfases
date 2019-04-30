using System;

namespace Interfases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFASES");
            //Console.WriteLine(" ");
            //Console.WriteLine("SABER SI ES HERVIVORO O CARNIVORO");
            //Console.WriteLine("Presione el simbolo para realizar la operacion:n");
            //Console.WriteLine("1 HERVIVORO");
            //Console.WriteLine("2 CARNIVORO");
            //Console.Write("n Eliga Una Opcion: "); 
            //string resp = Console.ReadLine();
            //string enviarr = Convert.ToString(resp);
            var enviarmensaje = new Leon();
            enviar(enviarmensaje, "prueba");
            var enviarmensaje2 = new Perro();
            enviar(enviarmensaje2, "prueba2");
            var enviarmensaje3 = new Vaca();
            enviar1(enviarmensaje3, "prueba3");
            var enviarmensaje4 = new oveja();
            enviar1(enviarmensaje4, "prueba4");

            Console.Read();
        }
        public static void enviar(ICarnivoro mensajero, string carnivoro)
        {
            mensajero.Alimentar(carnivoro);
        }
        public static void enviar1(IHervivoro mensajero, string hervivoro)
        {
            mensajero.Comer(hervivoro);
        }
    }
}
