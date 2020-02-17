using DddSuper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Domain.Interfaces.Repositories
{
    public interface ILancamentosRepository
    {
        Task<bool> TransferirAscync(Lancamentos lancamentos);      
    }
}
