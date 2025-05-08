namespace GuiaTuristica.API.Models;

public class Lugar
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Imagen { get; set; }
    public string Ubicacion { get; set; }
    
    public int TipoLugarId { get; set; }
    public TipoLugar? TipoLugar { get; set; }
    
    ICollection<Fotos> Fotos { get; set; } 
}