using DddSuper.Aplication.Interfaces;
using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DddSuper.Test.Service
{
    public class LancamentosServiceTest
    {
        ILancamentosService _iLancamentosService;

        public LancamentosServiceTest(ILancamentosService iLancamentosService) {
            _iLancamentosService = iLancamentosService;
        }

        [Fact]
        public async void Deve_Trasnferir_com_sucesso()
        {

            var entity = new Lancamentos()
            {
                DataLancamento = DateTime.Now,
                ContaDestino = new ContaCorrente { NumeroAgencia = "1234", NumeroConta = "1234567" },
                ContaOrigem = new ContaCorrente { NumeroAgencia = "4567", NumeroConta = "8974589" },
                Valor = 300

            };

            var result = await _iLancamentosService.TransferirAscync(entity);

            Assert.True(result, "Transferido com sucesso");

        }       
    }
}
