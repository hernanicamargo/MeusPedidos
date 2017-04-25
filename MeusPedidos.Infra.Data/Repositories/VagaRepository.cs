using System;
using System.Collections.Generic;
using MeusPedidos.Domain.Entities;
using MeusPedidos.Domain.Interfaces;
using System.Linq;

namespace MeusPedidos.Infra.Data.Repositories
{
    public class VagaRepository : RepositoryBase<Vaga>, IRepositoryVaga
    {
        public IEnumerable<Vaga> BuscarVagasAtivas()
        {
            return Db.Vagas.Where(x => x .Ativo == true);            
        }
    }
}
