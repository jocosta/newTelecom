using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NewTelecom.Domain.Interfaces.Repositories;
using NewTelecom.Infra.CrossCutting.Identity.Configuration;
using NewTelecom.Infra.CrossCutting.Identity.Context;
using NewTelecom.Infra.CrossCutting.Identity.Model;
using NewTelecom.Infra.Data.Repository;
using SimpleInjector;

namespace NewTelecom.Infra.CrossCutting.Ioc
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));

            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);


            container.Register<IAtendimentoChamadoRepositorio, AtendimentoChamadoRepositorio>(Lifestyle.Scoped);
            container.Register<IChamadoRepositorio, ChamadoRepositorio>(Lifestyle.Scoped);
            container.Register<IClientePessoaFisicaRepositorio, ClientePessoaFisicaRepositorio>(Lifestyle.Scoped);
            container.Register<IClientePessoaJurdicaRepositorio, ClientePessoaJurdicaRepositorio>(Lifestyle.Scoped);
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Scoped);
            container.Register<IContratoRepositorio, ContratoRepositorio>(Lifestyle.Scoped);
            container.Register<ICriticidadeRepositorioChamado, CriticidadeRepositorioChamado>(Lifestyle.Scoped);
            container.Register<IServicoRepositorio, ServicoRepositorio>(Lifestyle.Scoped);
            container.Register<ISituacaoChamadoRepositorio, SituacaoChamadoRepositorio>(Lifestyle.Scoped);
            container.Register<IStatusChamadoRepositorio, StatusChamadoRepositorio>(Lifestyle.Scoped);
            container.Register<IUsuarioRepositorio, UsuarioRepositorio>(Lifestyle.Scoped);
        }
    }
}
