namespace BibliotecaApi.Models;

public class Autor
{
    public int Id {get;set;}
    public string Alias {get;set;} =string.Empty;
    public string Edad {get;set;} = string.Empty;
    public ICollection<Libro>libros{get;set;} = new List<Libro>();
}