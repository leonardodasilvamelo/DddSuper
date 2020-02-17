using DddSuper.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Aplication.Interfaces
{
    public interface ILancamentosApp
    {
      Task<bool> TransferenciaAsync(LancamentosModel lancamentosModel);
    }
}
