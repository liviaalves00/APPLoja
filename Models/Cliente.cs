using System.ComponentModel.DataAnnotations.Schema;

namespace livia.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public virtual NotaDeVenda? NotaDeVenda { get; set; }
        [ForeignKey("NotaDeVenda")]
        public int? NotaDeVendaId { get; set; }
    }
}
