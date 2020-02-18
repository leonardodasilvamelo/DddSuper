using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DddSuper.Aplication.Models
{
    public class ContaCorrenteModel
    {
        public Guid Id { get; set; }

        public string NumeroConta { get; set; }

        public string NumeroAgencia { get; set; }

        public string Cpf { get; set; }
    }
}
