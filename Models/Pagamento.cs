
using System.ComponentModel.DataAnnotations.Schema;

namespace livia.Models
{
    public class Pagamento
    {
        public int Id { get; set; } 
        public DateTime DataLimite { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
        [ForeignKey("NotaDeVenda")]
        public int NotaDeVendaId { get; set; }
        public virtual NotaDeVenda? NotaDeVenda { get; set; }
    }
}
