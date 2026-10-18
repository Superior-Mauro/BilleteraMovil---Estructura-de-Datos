using billeteraMovilCajaArequipa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billeteraMovilCajaArequipa.Estructuras
{
    public class ListaHistorial
    {
        // Punteros al primer y último nodo para no perder la referencia en memoria
        private NodoOperacion inicio;
        private NodoOperacion fin;

        // Método para agregar un movimiento al final del historial (orden cronológico)
        public void Registrar(Operacion op)
        {
            NodoOperacion nuevoNodo = new NodoOperacion(op);

            // Si la lista está vacía, el nuevo nodo es el inicio y el fin a la vez
            if (inicio == null)
            {
                inicio = nuevoNodo;
                fin = nuevoNodo;
            }
            else
            {
                // Enlazamos el último nodo actual con el nuevo, y actualizamos el puntero 'fin'
                fin.Siguiente = nuevoNodo;
                fin = nuevoNodo;
            }
        }

        // Método para recorrer los nodos y pasarlos a la interfaz gráfica (DataGridView)
        public List<Operacion> ObtenerTodos()
        {
            List<Operacion> operacionesParaUI = new List<Operacion>();
            NodoOperacion actual = inicio; // Empezamos a recorrer desde el inicio

            // Recorremos la lista nodo por nodo mediante sus punteros 'Siguiente'
            while (actual != null)
            {
                operacionesParaUI.Add(actual.Datos);
                actual = actual.Siguiente; // Saltamos al siguiente nodo en memoria
            }

            return operacionesParaUI;
        }
    }
}