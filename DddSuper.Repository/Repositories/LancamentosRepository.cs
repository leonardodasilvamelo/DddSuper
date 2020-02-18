using DddSuper.Domain.Entities;
using DddSuper.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Infra.Data.Repositories
{
    public class LancamentosRepository : ILancamentosRepository
    {
        //Informações são uma simulação do banco de dados. Se fosse caso real utilizaria o Dapper.

        public async Task<bool> TransferirAscyncAsync(Lancamentos lancamentos)
        {
            //Entendi que o repositório de lançamento para o caso de transferência deveria fazer 
            // uma transação no banco de dados de debito e crédito e se caso desse qualquer erro, faria o rollback.

            await Task.Delay(1);
            return true;
        }
    }
}
