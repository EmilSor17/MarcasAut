namespace MarcasAut.Core.Interfaces
{
  //Aqui se listan las interfaces que podran ser trabajadas desde unit of work
  public interface IUnitOfWork : IDisposable
  {
    IMarcasRepository Marcas { get; }
  }
}
