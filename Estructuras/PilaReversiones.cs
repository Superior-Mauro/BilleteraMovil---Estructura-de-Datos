using billeteraMovilCajaArequipa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billeteraMovilCajaArequipa.Estructuras
{
    public class PilaReversiones
    {
        private NodoOperacion cima;

        public void Apilar(Operacion op)
        {
            NodoOperacion nuevoNodo = new NodoOperacion(op);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
        }

        public Operacion Desapilar()
        {
            if (cima == null) return null;

            Operacion op = cima.Datos;
            cima = cima.Siguiente;
            return op;
        }
    }
}
