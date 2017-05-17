using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class RanuraDeposito
    {
        public int RanuraDepositoId { get; set; }
        public double Deposito { get; set; }

        //ATM
        public ATM ATM { get; set; }
        public int ATMId { get; set; }

    }
}
