using BibliotecaApi.Models;
using BibliotecaApi.Repositories;

namespace BibliotecaApi.Services;


public class LibroService
{
    private readonly ILibroRepository repository;

    public LibroService(ILibroRepository repository)
    {
        this.repository = repository;
    }

    public List<Libro> ObtenerTodos()
    {
        return repository.ObtenerTodos();
    }

    public Libro? ObtenerPorId(int id)
    {
        return repository.ObtenerPorId(id);
    }

    public Libro Agregar(Libro libro)
    {
        return repository.Agregar(libro);
    }

    public bool Eliminar(int id)
    {
        return repository.Eliminar(id);
    }
}
