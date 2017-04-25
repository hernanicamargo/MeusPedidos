using MeusPedidos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MeusPedidos.Infra.Data.EntityConfig
{
    public class VagaRequisitoConfiguration: EntityTypeConfiguration<VagaRequisito>
    {
        public VagaRequisitoConfiguration()
        {
            HasKey(c => new { c.Id, c.RequisitoId, c.VagaId });            
        }
    }
}
