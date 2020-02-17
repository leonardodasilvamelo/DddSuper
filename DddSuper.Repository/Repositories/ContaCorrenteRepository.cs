using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Infra.Data.Repositories
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        public Task<ContaCorrente> GetContaAsync(string NumeroConta, string NumeroAgencia, string Cpf)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetSaldoAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
