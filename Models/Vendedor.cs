using System.ComponentModel.DataAnnotations.Schema;
namespace livia.Models;
public class Vendedor
{
    public int Id { get; set; }
    public string? Nome { get; set; }
   
    [ForeignKey("NotaDeVenda")]
    public int NotaDeVendaId { get; set; }
    public virtual NotaDeVenda? NotaDeVenda { get; set; }
}
