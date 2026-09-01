using BibliotecaApi.Models;
using BibliotecaApi.Repositories;

namespace BibliotecaApi.Services;

public class autorService
{
    private readonly IAutorRepository repository;

    public autorService(IAutorRepository repository)
    {
        this.repository = repository;
    }

    public List<Autor> ObtenerTodos()
    {
        return repository.ObtenerTodos();
    }

    public Autor? ObtenerPorId(int id)
    {
        return repository.ObtenerPorId(id);
    }

    public Autor Agregar(Autor autor)
    {
        return repository.Agregar(autor);
    }

    public bool Eliminar(int id)
    {
        return repository.Eliminar(id);
    }
}
