using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Aplication.Models
{
    public class LancamentosModel
    {
        public DateTime DataLancamento { get; set; }

        public ContaCorrenteModel ContaOrigem { get; set; }

        public ContaCorrenteModel ContaDestino { get; set; }

        public float Valor { get; set; }

    }
}
