
using System.ComponentModel.DataAnnotations.Schema;

namespace livia.Models
{
    public class NotaDeVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public virtual ICollection<Cliente>? ClienteVenda { get; set; }
        public virtual ICollection<Vendedor>? VendedorVenda { get; set; }
        public virtual ICollection<Transportadora>? TransportadoraVenda { get; set; }
        public virtual ICollection<Pagamento>? PagamentoVenda { get; set; }
        public int TipoDePagamentoId { get; set; }

        [ForeignKey("TipoDePagamentoId")]
        public virtual TipoDePagamento TipoDePagamento { get; set; }
        public void CancelarNotaDeVenda()
        {
        }
        public void Devolver()
        {
        }
    }
}
