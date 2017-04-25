using System;
using System.Collections.Generic;
using MeusPedidos.Domain.Entities;
using MeusPedidos.Domain.Interfaces;
using System.Linq;

namespace MeusPedidos.Infra.Data.Repositories
{
    public class VagaRequisitoRepository : RepositoryBase<VagaRequisito>, IRepositoryVagaRequisito
    {
        public IEnumerable<VagaRequisito> BuscarRequisitosVaga(int VagaId)
        {
            return Db.VagaRequisitos.Where(x => x.VagaId == VagaId);
        }
    }
}
