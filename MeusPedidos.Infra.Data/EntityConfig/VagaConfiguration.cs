using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class VagaConfiguration: EntityTypeConfiguration<Vaga>
    {
        public VagaConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Ativo)
                .IsRequired();
        }
    }
}
