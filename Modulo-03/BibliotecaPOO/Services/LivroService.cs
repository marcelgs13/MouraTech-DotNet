using BibliotecaCLI.Models;

namespace BibliotecaCLI.Services;

public class LivroService
{
    private List<Livro> livros = new();

    public void CadastrarLivro()
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();

        Livro livroExistente = livros.FirstOrDefault(livro => livro.ISBN == isbn);

        if (livroExistente != null)
        {
            Console.WriteLine("Erro: Já existe um livro cadastrado com este ISBN.");
            return;
        }

        Livro novoLivro = new Livro(titulo, autor, ano, isbn);

        livros.Add(novoLivro);

        Console.WriteLine("Livro cadastrado com sucesso!");
    }

    public void ListarLivros()
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }

        foreach (Livro livro in livros)
        {
            Console.WriteLine($"Título: {livro.Titulo} | Autor: {livro.Autor} | Ano: {livro.Ano} | ISBN: {livro.ISBN}");
        }
    }

    public void BuscarLivro()
    {
        Console.Write("Digite o título para busca: ");
        string busca = Console.ReadLine();

        var encontrados = livros
            .Where(livro => livro.Titulo.ToLower().Contains(busca.ToLower()))
            .ToList();

        if (encontrados.Count == 0)
        {
            Console.WriteLine("Nenhum livro encontrado.");
            return;
        }

        foreach (Livro livro in encontrados)
        {
            Console.WriteLine($"Título: {livro.Titulo} | Autor: {livro.Autor} | Ano: {livro.Ano} | ISBN: {livro.ISBN}");
        }
    }

    public void RemoverLivro()
    {
        Console.Write("Digite o ISBN para remover: ");
        string isbn = Console.ReadLine();

        Livro livro = livros.FirstOrDefault(livro => livro.ISBN == isbn);

        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        livros.Remove(livro);

        Console.WriteLine("Livro removido com sucesso!");
    }
}