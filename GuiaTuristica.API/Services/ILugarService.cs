using GuiaTuristica.API.Models;

namespace GuiaTuristica.API.Services;

public interface ILugarService
{
    Task<Lugar> CrearLugar(Lugar lugar);
    Task<Lugar> ObtenerLugar(int id);
    Task<List<Lugar>> ObtenerLugares();
}