using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTelecom.Domain.Entities;
using NewTelecom.Infra.Data.Configuration;
using NewTelecom.Infra.Data.Initializer;

namespace NewTelecom.Infra.Data.Context
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new ApplicationDbInitializer());
        }

        public DbSet<AtendimentoChamado> AtendimentosChamados { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<ClientePessoaFisica> ClientesPessoaFisica { get; set; }
        public DbSet<ClientePessoaJuridica> ClientesPessoaJuridica { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CriticidadeChamado> CriticidadesChamados { get; set; }
        public DbSet<StatusChamado> StatusChamados { get; set; }
        public DbSet<SituacaoContrato> SituacoesContratos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AtendimentoChamadoConfiguration());
            modelBuilder.Configurations.Add(new ChamadoConfiguration());
            modelBuilder.Configurations.Add(new ClientePessoaFisicaConfiguration());
            modelBuilder.Configurations.Add(new ClientePessoaJuridicaConfiguration());
            modelBuilder.Configurations.Add(new ContratoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
