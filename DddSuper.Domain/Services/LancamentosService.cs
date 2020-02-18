using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Repositories;
using DddSuper.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Domain.Services
{
    public class LancamentosService : ILancamentosService
    {
        private ILancamentosRepository _iLancamentosRepository;

        public LancamentosService(ILancamentosRepository iLancamentosRepositor) {

            _iLancamentosRepository = iLancamentosRepositor;
        }

        public Task<bool> TransferirAscync(Lancamentos lancamentos)
        {
            return _iLancamentosRepository.TransferirAscyncAsync(lancamentos);
        }
    }
}
