using System.ComponentModel.DataAnnotations.Schema;

namespace livia.Models
{
    public class Marca
    {
        public int Id { get; set; } 
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public virtual ICollection<Produto>? Produtos { get; set; }
        public int? MarcaProdutoId { get; set; }
        public virtual Marca? MarcaProduto { get; set; }
    }
}
