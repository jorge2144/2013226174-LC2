using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly CajeroAutomaticoContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IATMRepository ATM { get; private set; }
        public IBaseDeDatosRepository BaseDeDatos { get; private set; }
        public ICuentaRepository Cuenta { get; private set; }
        public IDispensadorEfectivoRepository DispensadorEfectivo { get; private set; }
        public IPantallaRepository Pantalla { get; private set; }
        public IRanuraDepositoRepository RanuraDeposito { get; private set; }
        public IRetiroRepository Retiro { get; private set; }
        public ITecladoRepository Teclado { get; private set; }

        private UnityOfWork()
        {
            _Context = new CajeroAutomaticoContext();

            ATM = new ATMRepository(_Context);
            BaseDeDatos = new BaseDeDatosRepository(_Context);
            Cuenta = new CuentaRepository(_Context);
            DispensadorEfectivo = new DispensadorEfectivoRepository(_Context);
            Pantalla =new PantallaRepository(_Context);
            RanuraDeposito = new RanuraDepositoRepository(_Context);
            Retiro = new RetiroRepository(_Context);
            Teclado = new TecladoRepository(_Context);


        }

        //Implementacion del patron singleton para iniciar la clase UnityofWork
        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }
                return _Instance;
            }
        }




        public void Dispose()
        {
            _Context.Dispose();
        }  

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }
    }
}
