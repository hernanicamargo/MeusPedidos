using MeusPedidos.Domain.Entities;
using MeusPedidos.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MeusPedidos.Infra.Data.Contexto
{
    public class MeusPedidosContexto : DbContext        
    {
        public MeusPedidosContexto()
            : base("MeusPedidosDB")
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Candidatura> Candidaturas { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Requisito> Requisitos { get; set; }
        public DbSet<RequisitoRating> RequisitoRatings { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<VagaRequisito> VagaRequisitos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CandidatoConfiguration());
            modelBuilder.Configurations.Add(new CandidaturaConfiguration());
            modelBuilder.Configurations.Add(new GrupoConfiguration());
            modelBuilder.Configurations.Add(new RequisitoConfiguration());
            modelBuilder.Configurations.Add(new RequisitoRatingConfiguration());
            modelBuilder.Configurations.Add(new VagaConfiguration());
            modelBuilder.Configurations.Add(new VagaRequisitoConfiguration());
        }
    }
}
