using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class Retiro
    {
        public int RetiroId { get; set; }

        public int Cantidad { get; set; }

        //DispensadorDeEfectivo
        public int DispensadorEfectivoId { get; set; }
        public DispensadorEfectivo DispensadorEfectivo { get; set; }

        //pantalla
        public int PantallaId { get; set; }
        public Pantalla Pantalla { get; set; }

        //ATM
        public int ATMId { get; set; }
        public ATM ATM { get; set; }

        //BaseDeDatos
        public int BaseDeDatosId { get; set; }
        public BaseDeDatos BaseDeDatos { get; set; }

    }
}
