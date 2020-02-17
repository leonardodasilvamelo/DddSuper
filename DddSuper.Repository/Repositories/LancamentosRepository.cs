using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Infra.Data.Repositories
{
    public class LancamentosRepository : ILancamentosRepository
    {

        public Task<bool> TransferirAscync(Lancamentos lancamentos)
        {
            throw new NotImplementedException();
        }
    }
}
