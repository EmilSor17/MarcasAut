using MarcasAut.Controllers;
using MarcasAut.Core.Entities;
using MarcasAut.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

public class MarcasControllerTests
{
  [Fact]
  public async Task GetMarcasAutos_ReturnsAllMarcas()
  {
    // Arrange: Mockear UnitOfWork y repositorio
    var mockMarcasRepo = new Mock<IMarcasRepository>();
    mockMarcasRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<MarcasAuto>
{
    new MarcasAuto { Id = 1, Name = "Toyota" },
    new MarcasAuto { Id = 2, Name = "Honda" },
    new MarcasAuto { Id = 3, Name = "Ford" }
});

    var mockUnitOfWork = new Mock<IUnitOfWork>();
    mockUnitOfWork.Setup(uow => uow.Marcas).Returns(mockMarcasRepo.Object);


    var controller = new MarcasController(mockUnitOfWork.Object);

    // Act: Llamar al método GetMarcasAutos
    var result = await controller.GetMarcasAutos();

    // Assert: Verificar resultados
    var okResult = Assert.IsType<OkObjectResult>(result);
    var marcas = Assert.IsType<List<MarcasAuto>>(okResult.Value);
    Assert.Equal(3, marcas.Count);
  }
}
