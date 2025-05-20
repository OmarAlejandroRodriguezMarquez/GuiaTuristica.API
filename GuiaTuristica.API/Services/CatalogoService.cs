using GuiaTuristica.API.Data;
using GuiaTuristica.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GuiaTuristica.API.Services;

public class CatalogoService : ICatalogoService
{
    private readonly ApplicationDbContext _context;

    public CatalogoService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<TipoLugar>> GetTiposLugares()
    {
        var tiposLugares = await _context.TipoLugares.ToListAsync();
        if (tiposLugares == null || !tiposLugares.Any())
        {
            throw new Exception("No se encontraron tipos de lugares.");
        }
        return tiposLugares;
    }

    public async Task<TipoLugar> CrearTipoLugar(TipoLugar tipoLugar)
    {
        _context.TipoLugares.Add(tipoLugar);
        var response = await _context.SaveChangesAsync();
        if (response > 0)
        {
            return tipoLugar;
        }
        throw new Exception("No se pudo crear el tipo de lugar.");
    }
}