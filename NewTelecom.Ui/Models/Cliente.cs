using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTelecom.Ui.Models
{
    public class Cliente
    {
        public virtual string ClienteId { get; set; }
        
        //PF
        public virtual string Cpf { get; set; }
        public virtual string DocIdentidade { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Cnpj { get; set; }

        //PJ
        public virtual string InscricaoEstadual { get; set; }
        public virtual string InscricaoMunicipal { get; set; }
    }
}