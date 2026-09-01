namespace BibliotecaApi.Models;

public class Categoria
{
    public int Id {get;set;}
    public string Nombre{get;set;} = string.Empty;
    public ICollection<Libro>libros{get;set;}=new List<Libro>();
}