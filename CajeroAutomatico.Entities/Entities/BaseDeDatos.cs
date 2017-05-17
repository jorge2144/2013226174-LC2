using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class BaseDeDatos
    {
        public int BaseDeDatosId { get; set; }
        // Cuentas
        public Cuenta Cuenta { get; set; }
        public int CuentaId { get; set; }
        public List<Cuenta> Cuentas;

        public BaseDeDatos()
        {
            Cuentas=new List<Cuenta>();
        }

        //Retiro
        public Retiro Retiro { get; set; }
        public int RetiroId { get; set; }

        //ATM
        public ATM ATM { get; set; }
        public int ATMId { get; set; }


        public bool AutentificarUsuario(int NumeroDeCuenta, int Pin)
        {
            return true;
        }
        public decimal ObtenerSaldoDisponible(int NumeroDeCuenta)
        {
            return 10;
        }
        public decimal ObtenerSaldoTotal(int NumeroDeCuenta)
        {
            return 10;
        }
        public void Debitar(int NumeroDeCuenta,decimal Monto)
        {

        }
        public void Acreditar(int NumeroDeCuenta,decimal Monto)
        {

        }
    }
}
