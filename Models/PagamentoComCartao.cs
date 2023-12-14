
namespace livia.Models;
public class PagamentoComCartao : TipoDePagamento {
    public int NumeroDoCartao {get;set;}
    public string? Bandeira {get;set;}
}