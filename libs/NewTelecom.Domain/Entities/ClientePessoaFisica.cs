using System;

namespace NewTelecom.Domain.Entities
{
    public class ClientePessoaFisica : Cliente
    {
        public virtual string Cpf { get; set; }
        public virtual string DocIdentidade { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}
