namespace src.Models;

public class Contrato
{
    public Contrato()
    {
        this.DataCriacao = DateTime.Now;
        this.Valor = 0;
        this.TokenId = "000000";
        this.Pago = false;
    }
    public Contrato(string TokenId, double Valor)
    {
        this.DataCriacao = DateTime.Now;
        this.TokenId = TokenId;
        this.Valor = Valor;
        this.Pago = false;
    }
    public DateTime DataCriacao { get; set; }
    public string TokenId { get; init; }
    public double Valor { get; set; }
    public bool Pago { get; set; }
    
    

}