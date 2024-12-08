namespace MarcasAut.Core.Entities
{
  public class MarcasAuto : BaseEntity
  {
    //Heredando de entidad base que contiene Id, de esta
    //manera se pueden usar los genericos con cualquier entidad
    //y solo se agregan las propiedades de cada entidad particular
    public string Name { get; set; }
  }
}
