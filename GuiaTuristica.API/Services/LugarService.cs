using GuiaTuristica.API.Data;
using GuiaTuristica.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GuiaTuristica.API.Services;

public class LugarService : ILugarService
{
    private readonly ApplicationDbContext _context;

    public LugarService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Lugar> CrearLugar(Lugar lugar)
    {
        if (lugar == null)
        {
            throw new ArgumentNullException(nameof(lugar), "El lugar no puede estar vacío");
        }

        await _context.Lugares.AddAsync(lugar);
        await _context.SaveChangesAsync();
        return lugar;
    }

    public async Task<Lugar> ObtenerLugar(int id)
    {
        var lugar = await _context.Lugares.FindAsync(id);
        if (lugar == null)
        {
            throw new KeyNotFoundException($"El lugar con id {id} no existe");
        }
        return lugar;
    }

    public async Task<List<Lugar>> ObtenerLugares()
    {
        var lugares = await _context.Lugares.ToListAsync();
        if (lugares == null || lugares.Count == 0)
        {
            throw new KeyNotFoundException("No se encontraron lugares");
        }
        return lugares;
    }
}