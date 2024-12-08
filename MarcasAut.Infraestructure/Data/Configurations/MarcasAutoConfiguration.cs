using MarcasAut.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarcasAut.Infraestructure.Data.Configurations
{
  //Configuracion tabla de esta entidad y de esquema de DB para esta tabla
  public class MarcasAutoConfiguration : IEntityTypeConfiguration<MarcasAuto>
  {
    public void Configure(EntityTypeBuilder<MarcasAuto> builder)
    {
      builder.HasKey(ig => ig.Id);

      builder.Property(ig => ig.Name)
          .IsRequired();

      builder.HasData(
          new MarcasAuto { Id = 1, Name = "Toyota" },
          new MarcasAuto { Id = 2, Name = "Ford" },
          new MarcasAuto { Id = 3, Name = "Chevrolet" });


      }
  }
}

