using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class ATM
    {
        public int ATMId { get; set; }

        //RanuraDeposito

        public int DepositoId { get; set; }
        public RanuraDeposito Deposito { get; set; }

        //Pantalla
        public int PantallaId { get; set; }
        public Pantalla Pantalla { get; set; }

        //Teclado
        public Teclado Teclado { get; set; }
        public int TecladoId { get; set; }

        //BaseDeDatos
        public BaseDeDatos BaseDeDatos { get; set; }
        public int BaseDeDatosId { get; set; }

        //DispensadorEfectivo
        public int DispensadorEfectivoId { get; set; }
        public DispensadorEfectivo DispensadorEfectivo { get; set; }

        //Retiro
        public int RetiroId { get; set; }
        public Retiro Retiro { get; set; }
        

    }
}
