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
        //Informações são uma simulação do banco de dados. Se fosse caso real utilizaria o Dapper.

        public async Task<ContaCorrente> GetContaAsync(string NumeroConta, string NumeroAgencia)
        {
            await Task.Delay(1);

            var contaCorrente = new ContaCorrente()
            {
                Id = Guid.Parse("33ed2881-2da4-4746-b19b-c2ad8eea869b"),
                NumeroAgencia = NumeroAgencia,
                NumeroConta = NumeroAgencia
            };

            return contaCorrente;
        }

        public async Task<decimal> GetSaldoAsync(Guid id)
        {
            await Task.Delay(1);

            return 400;
        }
    }
}
