using BibliotecaApi.Models;

namespace BibliotecaApi.Repositories;

public interface IAutorRepository
{
    List<Autor> ObtenerTodos();

    Autor? ObtenerPorId(int id);

    Autor Agregar(Autor autor);

    bool Eliminar(int id);
}