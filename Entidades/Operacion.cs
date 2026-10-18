using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billeteraMovilCajaArequipa.Entidades
{
    // Entidad de negocio
    public class Operacion
    {
        public string CodigoOperacion { get; set; }
        public decimal Monto { get; set; }
        public string Tipo { get; set; } // "Abono", "Transferencia", etc.
        public DateTime FechaHora { get; set; }

        public Operacion(string codigo, decimal monto, string tipo)
        {
            CodigoOperacion = codigo;
            Monto = monto;
            Tipo = tipo;
            FechaHora = DateTime.Now;
        }
    }
}
