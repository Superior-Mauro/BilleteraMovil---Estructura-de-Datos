using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billeteraMovilCajaArequipa.Entidades
{
    public class NodoOperacion
    {
        public Operacion Datos { get; set; }
        public NodoOperacion Siguiente { get; set; } // Puntero al siguiente nodo

        public NodoOperacion(Operacion datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }
}
