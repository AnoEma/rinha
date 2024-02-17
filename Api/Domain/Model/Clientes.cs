namespace Api.Domain.Model;

public class Clientes
{
    public int id { get; set; }
    public int valor { get; set; }
    public Tipos tipo { get; set; }
    public int limit { get; set; }
    public Saldo saldos { get; set; } = new();
    public IEnumerable<UltimasTransaco> ultimasTransacos { get; set; } = new List<UltimasTransaco>();
    public string descricao { get; set; } = string.Empty;
}