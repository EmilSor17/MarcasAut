using MarcasAut.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarcasAut.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MarcasController : ControllerBase
  {

    //Inyectando Unit of Work
    private readonly IUnitOfWork _unitOfWork;
    public MarcasController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    //Metodo Para obtener todas las marcas con su manejo de error
    [HttpGet]
    public async Task<IActionResult> GetMarcasAutos()
    {
      try
      {
        var marcas = await _unitOfWork.Marcas.GetAllAsync();
        return Ok(marcas);
      }
      catch(Exception ex)
      {
        return StatusCode(500,ex);
      }
    }
  }
}
