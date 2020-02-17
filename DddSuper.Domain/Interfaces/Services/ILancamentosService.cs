using DddSuper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Domain.Interfaces.Services
{
    public interface ILancamentosService
    {
        Task<bool> TransferirAscync(Lancamentos lancamentos);
    }
}
