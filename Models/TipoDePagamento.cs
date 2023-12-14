
namespace livia.Models;


public class TipoDePagamento {

    public int Id {get;set;}
    public string? NomeDoCobrado {get;set;}
    public string? InformacoesAdicionais {get;set;}
    public virtual ICollection<NotaDeVenda>? NotaDeVenda {get;set;}
}