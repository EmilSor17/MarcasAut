using MarcasAut.Core.Interfaces;
using MarcasAut.Infraestructure.Data;
using MarcasAut.Infraestructure.Repositories;

namespace MarcasAut.Infraestructure.Persistence
{
  // Unidad de trabajo para gestionar transacciones en la base de datos.
  public class UnitOfWork : IUnitOfWork
  {
    private readonly DatContext _Context;
    public UnitOfWork(DatContext Context)
    {
      _Context = Context;

      //Inicializando repositorio/repositorios utilizados para cada entidad
      Marcas = new MarcasRepository(_Context);
    }
    public IMarcasRepository Marcas { get; private set; }

    // Guarda los cambios realizados en la base de datos.
    public async Task<int> Complete()
    {
      return await _Context.SaveChangesAsync();
    }
    // Libera los recursos utilizados por la unidad de trabajo.
    public void Dispose()
    {
      _Context.Dispose();
    }
  }
}
