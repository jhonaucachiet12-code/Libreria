using BibliotecaApi.Models;
using BibliotecaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutoresController:ControllerBase
{
    private readonly autorService service;
    
    public AutoresController (autorService service)
    {
        this.service = service;
    }

    [HttpGet]
    public ActionResult<List<Autor>> ObtenerTodos()
    {
        return Ok(service.ObtenerTodos());
    }

    [HttpGet("{id}")]
    public ActionResult<Autor> ObtenerPorId(int id)
    {
        var autor = service.ObtenerPorId(id);

        if (autor == null)
            return NotFound();

        return Ok(autor);
    }


    [HttpPost]
    public ActionResult<Autor> Agregar(Autor autor)
    {
        var nuevoautor = service.Agregar(autor);

        return Ok(nuevoautor);
    }

    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        var eliminado = service.Eliminar(id);

        if (!eliminado)
            return NotFound();

        return NoContent();
    }

}
