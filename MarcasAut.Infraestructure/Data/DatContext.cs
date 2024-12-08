using MarcasAut.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MarcasAut.Infraestructure.Data
{
  public class DatContext: DbContext
  {
    public DatContext()
    {

    }
    public DatContext(DbContextOptions<DatContext> options) : base(options)
    {

    }
    // Colección de entidades en la base de datos.
    public virtual DbSet<MarcasAuto> Marcas { get; set; }

    /// <summary>
    /// Configura las entidades y relaciones del modelo usando configuraciones especificadas en el ensamblado actual.
    /// </summary>
    /// <param name="modelBuilder">El objeto que se usa para construir el modelo de entidad.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Aplica todas las configuraciones de entidad especificadas en el ensamblado actual.
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

  }
}
