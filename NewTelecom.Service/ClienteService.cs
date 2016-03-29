using NewTelecom.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTelecom.Service
{
    public class ClienteService
    {
        public async Task<ICollection<ClientePessoaFisica>> Listar()
        {
            var model = new List<ClientePessoaFisica>
            {
                new ClientePessoaFisica
                {
                    ClienteId = new Guid().ToString(),
                    Cpf = "396888178-80",
                    DataNascimento = new DateTime(1992, 11, 4),
                    DocIdentidade = "489791335",
                    Nome = "josé Romualdo"
                }    ,

                 new ClientePessoaFisica
                {
                    ClienteId = new Guid().ToString(),
                    Cpf = "396888178-81",
                    DataNascimento = new DateTime(1993, 2, 22),
                    DocIdentidade = "489791335",
                    Nome = "Mariana Santiago"
                }
            };
            return await Task.Run(() => model);
        }
    }
}
