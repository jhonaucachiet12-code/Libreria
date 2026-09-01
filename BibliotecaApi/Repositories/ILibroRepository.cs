using BibliotecaApi.Models;



namespace BibliotecaApi.Repositories;

public interface ILibroRepository
{
    List<Libro> ObtenerTodos();

    Libro? ObtenerPorId(int id);

    Libro Agregar(Libro libro);

    bool Eliminar(int id);
}
