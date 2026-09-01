using BibliotecaApi.Models;


namespace BibliotecaApi.Repositories;

public class LibroRepositoryMemoria : ILibroRepository
{
    private readonly List<Libro> libros = new()
    {
        new Libro
        {
            Id = 1,
            Titulo = "El Hobbit",
            Autor = "J.R.R. Tolkien",
            AnioPublicacion = 1937
        },

        new Libro
        {
            Id = 2,
            Titulo = "1984",
            Autor = "George Orwell",
            AnioPublicacion = 1949
        }
    };

    public List<Libro> ObtenerTodos()
    {
        return libros;
    }

    public Libro? ObtenerPorId(int id)
    {
        return libros.FirstOrDefault(l => l.Id == id);
    }

    public Libro Agregar(Libro libro)
    {
        libro.Id = libros.Count > 0
            ? libros.Max(l => l.Id) + 1
            : 1;

        libros.Add(libro);

        return libro;
    }

    public bool Eliminar(int id)
    {
        var libro = ObtenerPorId(id);

        if (libro == null)
            return false;

        libros.Remove(libro);

        return true;
    }
}