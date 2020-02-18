using DddSuper.Aplication.Interfaces;
using DddSuper.Aplication.Models;
using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DddSuper.Aplication.Services
{
    public class LancamentosApp : ILancamentosApp
    {
        ILancamentosService _iLancamentosService;
        IContaCorrenteService _iContaCorrenteService;
        private readonly IMapper _mapper;

        public LancamentosApp(ILancamentosService iLancamentosService, IContaCorrenteService iContaCorrenteService, IMapper mapper)
        {
            _iLancamentosService = iLancamentosService;
            _iContaCorrenteService = iContaCorrenteService;
            _mapper = mapper;
        }

        public async Task<bool> TransferenciaAsync(LancamentosModel lancamentosModel)
        {
            if (lancamentosModel.ContaOrigem != lancamentosModel.ContaDestino)
            {
                var entity = _mapper.Map<Lancamentos>(lancamentosModel);

                var existeSaldo = await _iContaCorrenteService.ExiteSaldoSAsync(entity.ContaOrigem, entity.Valor);

                return existeSaldo ? await _iLancamentosService.TransferirAscync(entity) : false;
            }
            else
            {
                return false;
            }
        }
    }
}
