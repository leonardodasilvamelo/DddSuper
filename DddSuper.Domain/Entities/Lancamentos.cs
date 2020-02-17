using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Domain.Entities
{
    public class Lancamentos : EntityBase
    {        

        public DateTime DataLancamento { get; set; }

        public ContaCorrente ContaOrigem { get; set; }

        public ContaCorrente ContaDestino { get; set; }

        public decimal Valor { get; set; }

    }
}
