using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class RequisitoRatingConfiguration: EntityTypeConfiguration<RequisitoRating>
    {
        public RequisitoRatingConfiguration()
        {
            HasKey(c => new { c.CandidaturaId, c.VagaId, c.RequisitoId });

            Property(c => c.Rating)
                .IsRequired();
        }
    }
}
