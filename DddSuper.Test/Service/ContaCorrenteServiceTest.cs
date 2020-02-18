using DddSuper.Aplication.Models;
using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DddSuper.Test.Service
{
    public class ContaCorrenteServiceTest
    {
        private IContaCorrenteService _iContaCorrenteService;


        public ContaCorrenteServiceTest(IContaCorrenteService iContaCorrenteService) {
            _iContaCorrenteService = iContaCorrenteService;
        }

        public async void Deve_exibir_saldo_com_sucesso() {


            var result = await _iContaCorrenteService.GetSaldoAsync(Guid.NewGuid());
            Assert.True(result > 0, "Saldo retornado com sucesso");
        }

        public async void Deve_verificar_saldo_com_sucesso()
        {
            var entity = new ContaCorrente { NumeroAgencia = "1234", NumeroConta = "1234567" };

            var result = await _iContaCorrenteService.ExiteSaldoSAsync(entity, 200);
            Assert.True(result, "Existe saldo para tranferência");
        }

        public async void Deve_verificar_saldo_com_erro()
        {
            var entity = new ContaCorrente { NumeroAgencia = "1234", NumeroConta = "1234567" };

            var result = await _iContaCorrenteService.ExiteSaldoSAsync(entity, 10000);
            Assert.False( result, " Não existe saldo para tranferência");
        }

    }
}
