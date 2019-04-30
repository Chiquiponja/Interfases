using System;
using System.Collections.Generic;
using System.Text;

namespace Interfases
{
    public class Perro : ICarnivoro
    {
        public void Alimentar(string carnivoro)
        {
            Console.Write(" PERRO ES CARNIVORO ");
        }
    }
}
