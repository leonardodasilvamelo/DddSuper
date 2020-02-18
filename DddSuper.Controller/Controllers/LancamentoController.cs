using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DddSuper.Aplication.Interfaces;
using DddSuper.Aplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DddSuper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
        ILancamentosApp _iLancamentosApp;

        public LancamentoController(ILancamentosApp iLancamentosAp) {

            _iLancamentosApp = iLancamentosAp;
        }  

        [HttpPost]
        [Route("transferencia")]
        public async Task<bool> TransferenciaAsync([FromBody]LancamentosModel lancamentosModel)
        {
            return await _iLancamentosApp.TransferenciaAsync(lancamentosModel);
        }
    }
}