using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class Pantalla
    {
        public int PantallaId { get; set; }

        //Retiro
        public Retiro Retiro { get; set; }
        public int RetiroId { get; set; }

        //ATM
        public ATM ATM { get; set; }
        public int ATMId { get; set; }




    }
}
