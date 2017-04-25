using MeusPedidos.Domain.Entities;
using System.Collections.Generic;

namespace MeusPedidos.Domain.Interfaces
{
    public interface IRepositoryVaga: IRepositoryBase<Vaga>
    {
        IEnumerable<Vaga> BuscarVagasAtivas();
    }
}
