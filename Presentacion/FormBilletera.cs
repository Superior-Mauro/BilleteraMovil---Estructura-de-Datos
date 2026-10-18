using billeteraMovilCajaArequipa.Entidades;
using billeteraMovilCajaArequipa.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billeteraMovilCajaArequipa.Presentacion
{
    public partial class FormBilletera : Form
    {
        // Instanciamos las tres estructuras dinámicas
        private ColaTransacciones colaLlegadas = new ColaTransacciones();
        private PilaReversiones pilaReversos = new PilaReversiones();
        private ListaHistorial historial = new ListaHistorial();

        public FormBilletera()
        {
            InitializeComponent();
        }

        private void btnRecibirTransferencia_Click(object sender, EventArgs e)
        {
            // Validamos que el usuario haya escrito un número en txtMonto
            if (decimal.TryParse(txtMonto.Text, out decimal montoIngresado))
            {
                Operacion nuevaOp = new Operacion("OP" + new Random().Next(1000, 9999), montoIngresado, "Transferencia Entrante");

                colaLlegadas.Encolar(nuevaOp);

                // Actualizamos el ListBox visual para ver la cola en vivo
                lstCola.Items.Add($"{nuevaOp.CodigoOperacion} - S/ {nuevaOp.Monto}");
                txtMonto.Clear(); // Limpiamos la caja de texto para la siguiente

                MessageBox.Show("Operación encolada correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido en la caja de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesarSiguiente_Click(object sender, EventArgs e)
        {
            Operacion opProcesada = colaLlegadas.Desencolar();

            if (opProcesada != null)
            {
                // 1. Apilamos por si el usuario necesita revertir (LIFO)
                pilaReversos.Apilar(opProcesada);

                // 2. Registramos en el historial general (Lista Enlazada)
                historial.Registrar(opProcesada);

                // 3. Actualizamos la interfaz gráfica
                if (lstCola.Items.Count > 0) lstCola.Items.RemoveAt(0); // Sale el primero de la fila visual
                ActualizarGrillaHistorial(); // Refrescamos el DataGridView

                MessageBox.Show($"Se procesó y registró: {opProcesada.CodigoOperacion}");
            }
            else
            {
                MessageBox.Show("No hay transferencias pendientes en la cola.");
            }
        }

        private void btnRevertirUltima_Click(object sender, EventArgs e)
        {
            Operacion opRevertida = pilaReversos.Desapilar();

            if (opRevertida != null)
            {
                // Registramos la acción de reversión en el historial general
                Operacion reverso = new Operacion("REV-" + opRevertida.CodigoOperacion, opRevertida.Monto, "Reversión");
                historial.Registrar(reverso);

                ActualizarGrillaHistorial();

                MessageBox.Show($"Reversión exitosa de la operación: {opRevertida.CodigoOperacion}. El monto de S/ {opRevertida.Monto} ha sido retrocedido.");
            }
            else
            {
                MessageBox.Show("No hay operaciones recientes en la pila para revertir.");
            }
        }

        // Método auxiliar para pintar los nodos de la Lista Enlazada en el DataGridView
        private void ActualizarGrillaHistorial()
        {
            dgvHistorial.DataSource = null; // Limpiamos origen
            dgvHistorial.DataSource = historial.ObtenerTodos(); // Cargamos la lista actualizada
        }
    }
}