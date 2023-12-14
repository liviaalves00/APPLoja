namespace livia.Models;

public class PagamentoComCheque :  TipoDePagamento {
    public int Banco {get;set;}
    public string? NomeDoBanco {get; set;}
}