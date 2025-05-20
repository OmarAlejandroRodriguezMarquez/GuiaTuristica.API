using GuiaTuristica.API.Models;
using GuiaTuristica.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuiaTuristica.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LugarController : ControllerBase
{
   private readonly ILugarService _lugarService;

   public LugarController(ILugarService lugarService)
   {
      _lugarService = lugarService;
   }
   
   [HttpGet("lugares")]
   public async Task<ActionResult> ObtenerLugares()
   {
      try
      {
         var lugares = await _lugarService.ObtenerLugares();
         return Ok(lugares);
      }
      catch (Exception ex)
      {
         return BadRequest(ex.Message);
      }
   }
   
   [HttpGet("lugar/{id}")]
   public async Task<ActionResult> ObtenerLugar(int id)
   {
      try
      {
         var lugar = await _lugarService.ObtenerLugar(id);
         return Ok(lugar);
      }
      catch (Exception ex)
      {
         return BadRequest(ex.Message);
      }
   }
   
   [HttpPost("crear")]
   public async Task<ActionResult> CrearLugar([FromBody] Lugar lugar)
   {
      try
      {
         var nuevoLugar = await _lugarService.CrearLugar(lugar);
         return Ok(nuevoLugar);
      }
      catch (Exception ex)
      {
         return BadRequest(ex.Message);
      }
   }
}