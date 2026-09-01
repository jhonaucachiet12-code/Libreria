using BibliotecaApi.Models;


namespace BibliotecaApi.Repositories;

public class AutorRepositeryMemoria:IAutorRepository
{
    private readonly List<Autor> autores=new()
    {
        new Autor()
        {
            Id= 1,
            Alias = "J.R.R. Tolkien",
            libros = new List<Libro>
            {
                new Libro{Id = 1, Titulo = "El Hobbit", Autor = "J.R.R. Tolkien", AnioPublicacion = 1937}
            }

        },

        
    };
    public List<Autor> ObtenerTodos()
    {
        return autores;
    }

    public Autor ? ObtenerPorId(int id)
    {
        return autores.FirstOrDefault(a => a.Id == id);
    } 

    public Autor Agregar(Autor autor)
    {
        autor.Id = autores.Count > 0
            ? autores.Max(l => l.Id) + 1
            : 1;

        autores.Add(autor);

        return autor;
    }

    public bool Eliminar (int id)
    {
        var autors = ObtenerPorId(id);

        if(autors == null)
        {
            return false;
        }
        autores.Remove(autors);

        return true;
    } 
}