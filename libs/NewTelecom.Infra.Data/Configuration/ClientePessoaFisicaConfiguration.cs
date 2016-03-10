using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTelecom.Domain.Entities;

namespace NewTelecom.Infra.Data.Configuration
{
    public class ClientePessoaFisicaConfiguration : EntityTypeConfiguration<ClientePessoaFisica>
    {
        public ClientePessoaFisicaConfiguration()
        {
            ToTable("ClientePessoaFisica");

        }
    }
}
