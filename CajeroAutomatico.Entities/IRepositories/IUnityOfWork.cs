using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities.IRepositories
{
    //hereda de IDisposable
    public interface IUnityOfWork :IDisposable
    {

        IATMRepository ATM { get; }
        IBaseDeDatosRepository BaseDeDatos { get; }
        ICuentaRepository Cuenta { get; }
        IDispensadorEfectivoRepository DispensadorEfectivo { get; }
        IPantallaRepository Pantalla { get; }
        IRanuraDepositoRepository RanuraDeposito { get; }
        IRetiroRepository Retiro { get; }
        ITecladoRepository Teclado { get; }

        int SaveChanges();

    }
}
