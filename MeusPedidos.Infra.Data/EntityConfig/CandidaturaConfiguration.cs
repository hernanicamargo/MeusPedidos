using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class CandidaturaConfiguration: EntityTypeConfiguration<Candidatura>
    {
        public CandidaturaConfiguration()
        {
            HasKey(c => new { c.Id, c.CandidatoId, c.VagaId });

            Property(c => c.Data)
                .IsRequired();
        }
    }
}
