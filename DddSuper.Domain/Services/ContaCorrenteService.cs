using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Repositories;
using DddSuper.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Domain.Services
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        IContaCorrenteRepository _iContaCorrenteRepository;


        public ContaCorrenteService(IContaCorrenteRepository iContaCorrenteRepository) {
            _iContaCorrenteRepository = iContaCorrenteRepository;
        }

        public async Task<bool> ExiteSaldoSAsync(ContaCorrente contaCorrente, decimal ValorDebitar)
        {

            var conta = await _iContaCorrenteRepository.GetContaAsync(contaCorrente.NumeroConta, contaCorrente.NumeroAgencia);

            var saldo = await GetSaldoAsync(conta.Id);

            return saldo < ValorDebitar;
        }

        public async Task<decimal> GetSaldoAsync(Guid Id)
        {
            return await _iContaCorrenteRepository.GetSaldoAsync(Id);
        }
    }
}
