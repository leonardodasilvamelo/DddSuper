using DddSuper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Domain.Interfaces.Services
{
    public interface IContaCorrenteService
    {
        Task<decimal> GetSaldoAsync(Guid id);

        Task<bool> ExiteSaldoSAsync(ContaCorrente contaCorrente, decimal ValorDebitar);
    }
}
