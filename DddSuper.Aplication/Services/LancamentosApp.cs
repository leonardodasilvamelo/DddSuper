using DddSuper.Aplication.Interfaces;
using DddSuper.Aplication.Models;
using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Aplication.Services
{
    public class LancamentosApp : ILancamentosApp
    {
        ILancamentosService _iLancamentosService;
        IContaCorrenteService _iContaCorrenteService;

        public LancamentosApp(ILancamentosService iLancamentosService, IContaCorrenteService iContaCorrenteService)
        {
            _iLancamentosService = iLancamentosService;
            _iContaCorrenteService = iContaCorrenteService;
        }

        public async Task<bool> TransferenciaAsync(LancamentosModel lancamentosModel)
        {
            var teste = lancamentosModel.ContaOrigem != lancamentosModel.ContaDestino;

            var entity = new Lancamentos();

            var existeSaldo = await _iContaCorrenteService.ExiteSaldoSAsync(entity.ContaOrigem, entity.Valor);

            return existeSaldo ? await _iLancamentosService.TransferirAscync(entity) : false;
        }
    }
}
