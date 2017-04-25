using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class CandidatoConfiguration : EntityTypeConfiguration<Candidato>
    {
        public CandidatoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
