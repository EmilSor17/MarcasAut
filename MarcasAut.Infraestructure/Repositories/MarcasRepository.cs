using MarcasAut.Core.Entities;
using MarcasAut.Core.Interfaces;
using MarcasAut.Infraestructure.Data;

namespace MarcasAut.Infraestructure.Repositories
{
  //Repositorio que hereda los repositorios genericos para manejar la tabla especificada

  public class MarcasRepository : BaseRepository<MarcasAuto>, IMarcasRepository
  {
    public MarcasRepository(DatContext context) : base(context)
    {
    }
  }
}
