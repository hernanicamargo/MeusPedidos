using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class GrupoConfiguration: EntityTypeConfiguration<Grupo>
    {
        public GrupoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Descricao)
                .IsRequired();
        }
    }
}
