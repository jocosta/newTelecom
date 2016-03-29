using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTelecom.Web.Models
{
    public class ClientePf
    {
        public string ClienteId { get; set; }
        public virtual string Cpf { get; set; }
        public virtual string DocIdentidade { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}
