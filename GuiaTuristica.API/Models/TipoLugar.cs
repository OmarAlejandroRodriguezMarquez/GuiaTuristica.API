namespace GuiaTuristica.API.Models;

public class TipoLugar
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    
    ICollection<Lugar> Lugares { get; set; } 
}