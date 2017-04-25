using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class RequisitoConfiguration: EntityTypeConfiguration<Requisito>
    {
        public RequisitoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.GrupoId)
                .IsRequired();

            Property(c => c.Descricao)
                .IsRequired();
        }
    }
}
