namespace BibliotecaCLI.Models;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string ISBN { get; set; }

    public Livro(string titulo, string autor, int ano, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        ISBN = isbn;
    }
}