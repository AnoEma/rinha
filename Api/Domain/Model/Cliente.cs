namespace Api.Domain.Model;

public class Cliente
{
    public int id { get; set; }
    public Saldo saldos { get; set; } = new();
    public IEnumerable<UltimasTransaco> ultimasTransacos { get; set; } = new List<UltimasTransaco>();
}