using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_8.RecursosInterfaz
{
    class CbxMeses
    {
        public string Texto { get; set; }
        public object Valor { get; set; }

        public override string ToString()
        {
            return Texto;
        }

    }
}
