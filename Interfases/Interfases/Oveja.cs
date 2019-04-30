using System;
using System.Collections.Generic;
using System.Text;

namespace Interfases
{
    public class oveja : IHervivoro
    {
        public void Comer(string hervivoro)
        {
            Console.Write("  OVEJA ES HERVIVORO");
        }
    }
}
