using DddSuper.Aplication.Interfaces;
using DddSuper.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DddSuper.Test.Aplication
{
   

    public class LancamentosAppTest
    {
        ILancamentosApp _lancamentosApp;

        public LancamentosAppTest(ILancamentosApp lancamentosApp) {

            _lancamentosApp = lancamentosApp;
        }

        [Fact]
        public async void Deve_trasferir_com_sucessoAsync() {

            var lancamentoModel = new LancamentosModel() {
                DataLancamento = DateTime.Now,
                ContaDestino = new ContaCorrenteModel { NumeroAgencia = "1234", NumeroConta= "1234567"},
                ContaOrigem = new ContaCorrenteModel { NumeroAgencia = "4567", NumeroConta = "8974589" },
                Valor = 300
                
            };


            bool result = await _lancamentosApp.TransferenciaAsync(lancamentoModel);


            Assert.True(result, "Transferido com sucesso!");
        }

        [Fact]
        public async void Deve_trasferir_com_erro_sem_saldoAsync()
        {

            var lancamentoModel = new LancamentosModel()
            {
                DataLancamento = DateTime.Now,
                ContaDestino = new ContaCorrenteModel { NumeroAgencia = "1234", NumeroConta = "1234567" },
                ContaOrigem = new ContaCorrenteModel { NumeroAgencia = "4567", NumeroConta = "8974589" },
                Valor = 700

            };

            bool result = await _lancamentosApp.TransferenciaAsync(lancamentoModel);


            Assert.False(result, "A conta de origem não possui saldo");
        }

        [Fact]
        public async void Deve_trasferir_com_erro_conta_de_origem_e_destino_iguaisAsync()
        {

            var lancamentoModel = new LancamentosModel()
            {
                DataLancamento = DateTime.Now,
                ContaDestino = new ContaCorrenteModel { NumeroAgencia = "1234", NumeroConta = "1234567" },
                ContaOrigem = new ContaCorrenteModel { NumeroAgencia = "1234", NumeroConta = "1234567" },
                Valor = 700

            };

            bool result = await _lancamentosApp.TransferenciaAsync(lancamentoModel);

            Assert.False(result, "A conta de origem não possui saldo");
        }


    }
}
