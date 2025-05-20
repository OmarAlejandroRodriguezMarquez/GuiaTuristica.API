using GuiaTuristica.API.Models;

namespace GuiaTuristica.API.Services;

public interface ICatalogoService
{
    Task<List<TipoLugar>> GetTiposLugares();
    Task<TipoLugar> CrearTipoLugar(TipoLugar tipoLugar);
}