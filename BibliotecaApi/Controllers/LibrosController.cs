using BibliotecaApi.Models;
using BibliotecaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibrosController : ControllerBase
{
    private readonly LibroService service;

    public LibrosController(LibroService service)
    {
        this.service = service;
    }

    [HttpGet]
    public ActionResult<List<Libro>> ObtenerTodos()
    {
        return Ok(service.ObtenerTodos());
    }

    [HttpGet("{id}")]
    public ActionResult<Libro> ObtenerPorId(int id)
    {
        var libro = service.ObtenerPorId(id);

        if (libro == null)
            return NotFound();

        return Ok(libro);
    }

    [HttpPost]
    public ActionResult<Libro> Agregar(Libro libro)
    {
        var nuevoLibro = service.Agregar(libro);

        return Ok(nuevoLibro);
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