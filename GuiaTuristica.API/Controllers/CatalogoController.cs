using GuiaTuristica.API.Data;
using GuiaTuristica.API.Models;
using GuiaTuristica.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuiaTuristica.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly ICatalogoService _catalogoService;

    public CatalogoController(ICatalogoService catalogoService)
    {
        _catalogoService = catalogoService;
    }
    
    //Obtener todos los lugares
    [HttpGet("tiposlugar")]
    public async Task<ActionResult<List<TipoLugar>>> GetTiposLugares()
    {
        try
        {
            var tiposLugares = await _catalogoService.GetTiposLugares();
            return Ok(tiposLugares);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    //Crear un nuevo tipo de lugar
    [HttpPost("creartipolugar")]
    public async Task<ActionResult<TipoLugar>> CreateTipoLugar([FromBody] TipoLugar tipoLugar)
    {
        try
        {
            if (tipoLugar == null)
            {
                return BadRequest("El tipo de lugar no puede ser nulo.");
            }

            var nuevoTipoLugar = await _catalogoService.CrearTipoLugar(tipoLugar);
            return tipoLugar;
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}