using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DddSuper.Aplication.Interfaces;
using DddSuper.Aplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.HPack;

namespace DddSuper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
        private ILancamentosApp _iLancamentosApp;

        public LancamentoController(ILancamentosApp iLancamentosAp) {

            _iLancamentosApp = iLancamentosAp;
        }  

        [HttpPost]
        [Route("transferencia")]
        public async Task<IActionResult> TransferenciaAsync([FromBody]LancamentosModel lancamentosModel)
        {
            var status = await _iLancamentosApp.TransferenciaAsync(lancamentosModel);        

            if (status)
                return Ok();
            else
                return BadRequest();
        }
    }
}