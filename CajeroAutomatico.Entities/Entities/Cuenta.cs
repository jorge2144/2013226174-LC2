using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class Cuenta
    {
        public int CuentaId { get; set; }

        public int NumCuenta { get; set; }

        public int Pin { get; set; }

        public double Monto { get; set; }

        //BaseDeDatos
        public BaseDeDatos BaseDeDatos { get; set; }
        public int BaseDeDatosId { get; set; }


    }
}
