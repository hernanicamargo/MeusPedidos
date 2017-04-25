using MeusPedidos.Domain.Entities;
using System.Collections.Generic;

namespace MeusPedidos.Domain.Interfaces
{
    public interface IRepositoryVagaRequisito:IRepositoryBase<VagaRequisito>
    {
        IEnumerable<VagaRequisito> BuscarRequisitosVaga(int VagaId);
    }
}
