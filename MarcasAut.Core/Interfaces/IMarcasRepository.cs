using MarcasAut.Core.Entities;

namespace MarcasAut.Core.Interfaces
{
  /// Se hereda de la interfaz de repositorio base para listar los metodos implicitamente
  public interface IMarcasRepository : IBaseRepository<MarcasAuto>
  {
    // Métodos específicos para la gestión de MarcasAuto pueden ser añadidos aquí.
  }
}
