using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class Teclado
    {
        public int TecladoId { get; set; }

        public int Pin { get; set; }

        public int NumeroCuenta { get; set; }

        //retiro
        public Retiro Retiro { get; set; }
        public int RetiroId { get; set; }

        //ATM
        public ATM ATM{ get; set; }
        public int ATMId { get; set; }
    }
}
