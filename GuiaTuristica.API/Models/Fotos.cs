namespace GuiaTuristica.API.Models;

public class Fotos
{
    public int Id { get; set; }
    public string URL { get; set; }
    
    public int LugarId { get; set; }
    public Lugar? Lugar { get; set; }
}