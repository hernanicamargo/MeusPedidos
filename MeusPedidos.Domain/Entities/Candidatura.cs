using System;

namespace MeusPedidos.Domain.Entities
{
    public class Candidatura
    {
        public int Id { get; set; }
        public int CandidatoId { get; set; }
        public int VagaId { get; set; }
        public DateTime Data { get; set; }
    }
}
