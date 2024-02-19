namespace Api.Domain.Model;

public class SaldoClientes
{
    public int id { get; set; }
    public Tipos tipo { get; set; }
    public Saldo saldos { get; set; } = new();
    public IEnumerable<UltimasTransaco> ultimasTransacos { get; set; } = new List<UltimasTransaco>();
    public string descricao { get; set; } = string.Empty;
}