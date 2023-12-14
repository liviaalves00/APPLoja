using System.ComponentModel.DataAnnotations.Schema;

namespace livia.Models
{
    public class Item
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto? Produto { get; set; }
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
    }
}
