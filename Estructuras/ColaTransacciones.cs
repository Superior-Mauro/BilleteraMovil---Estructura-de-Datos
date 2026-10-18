using billeteraMovilCajaArequipa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billeteraMovilCajaArequipa.Estructuras
{
    public class ColaTransacciones
    {
        private NodoOperacion frente;
        private NodoOperacion final;

        public void Encolar(Operacion op)
        {
            NodoOperacion nuevoNodo = new NodoOperacion(op);
            if (frente == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }

        public Operacion Desencolar()
        {
            if (frente == null) return null;

            Operacion op = frente.Datos;
            frente = frente.Siguiente;
            if (frente == null) final = null;

            return op;
        }
    }
}
