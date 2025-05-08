using GuiaTuristica.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GuiaTuristica.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

    public DbSet<Fotos> Fotos { get; set; }
    public DbSet<Lugar> Lugares { get; set; }
    public DbSet<TipoLugar> TipoLugares { get; set; }
}