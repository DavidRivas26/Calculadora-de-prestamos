using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_8.RecursosInterfaz
{
    class CbxPrestamo
    {
        public string Texto { get; set; }
        public object Valor { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}
