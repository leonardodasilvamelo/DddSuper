using System;
using System.Collections.Generic;
using System.Text;

namespace DddSuper.Domain.Entities
{
    public class ContaCorrente : EntityBase
    {      

        public string NumeroConta {get; set;}

        public string NumeroAgencia { get; set; }

        public string Cpf { get; set; }

    }
}
