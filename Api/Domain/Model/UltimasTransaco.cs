namespace Api.Domain.Model;

public class UltimasTransaco
{
    public int valor { get; set; }
    public Tipos tipo { get; set; }
    public string descricao { get; set; } = string.Empty;
    public DateTime realizada_em { get; set; } = DateTime.Now;
}