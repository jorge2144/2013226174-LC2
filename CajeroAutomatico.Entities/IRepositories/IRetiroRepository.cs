﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities.IRepositories
{
    public interface IRetiroRepository : IRepository <Retiro>
    {
        IEnumerable<Cuenta> GetDinero(int idCuenta);
    }
}
