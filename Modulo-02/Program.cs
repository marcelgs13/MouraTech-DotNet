using System.Collections.Generic;

List<string> livros = new();
bool executando = true;

while (executando)
{
    MostrarMenu();

    Console.Write("Escolha uma opção: ");
    string entrada = Console.ReadLine();

    switch (entrada)
    {
        case "1":
            CadastrarLivro();
            break;

        case "2":
            ListarLivros();
            break;

        case "3":
            BuscarLivro();
            break;

        case "4":
            RemoverLivro();
            break;

        case "5":
            executando = false;
            Console.WriteLine("Sistema encerrado!");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("===== BIBLIOTECA =====");
    Console.WriteLine("1 - Cadastrar livro");
    Console.WriteLine("2 - Listar livros");
    Console.WriteLine("3 - Buscar livro");
    Console.WriteLine("4 - Remover livro");
    Console.WriteLine("5 - Sair");
    Console.WriteLine();
}

void CadastrarLivro()
{
    Console.Write("Digite o título do livro: ");
    string titulo = Console.ReadLine();

    Console.Write("Digite o autor do livro: ");
    string autor = Console.ReadLine();

    Console.Write("Digite o ano de publicação: ");
    string anoTexto = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(titulo) ||
        string.IsNullOrWhiteSpace(autor) ||
        string.IsNullOrWhiteSpace(anoTexto))
    {
        Console.WriteLine("Erro: Nenhum campo pode ficar vazio.");
        return;
    }

    int ano;

    if (!int.TryParse(anoTexto, out ano))
    {
        Console.WriteLine("Erro: O ano deve ser um número inteiro.");
        return;
    }

    foreach (string livro in livros)
    {
        if (livro.ToLower().Contains(titulo.ToLower()))
        {
            Console.WriteLine("Erro: Este livro já está cadastrado.");
            return;
        }
    }

    string livroCompleto = $"{titulo} - {autor} ({ano})";

    livros.Add(livroCompleto);

    Console.WriteLine("Livro cadastrado com sucesso!");
}

void ListarLivros()
{
    if (livros.Count == 0)
    {
        Console.WriteLine("Nenhum livro cadastrado.");
        return;
    }

    Console.WriteLine();
    Console.WriteLine("===== ACERVO ATUAL =====");

    foreach (string livro in livros)
    {
        Console.WriteLine($"- {livro}");
    }

    Console.WriteLine();
    Console.WriteLine($"Total de livros no acervo: {livros.Count}");
}

void BuscarLivro()
{
    Console.Write("Digite o termo de busca: ");
    string busca = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(busca))
    {
        Console.WriteLine("Erro: O termo de busca não pode ser vazio.");
        return;
    }

    bool encontrado = false;

    foreach (string livro in livros)
    {
        if (livro.ToLower().Contains(busca.ToLower()))
        {
            Console.WriteLine($"Livro encontrado: {livro}");
            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Livro não encontrado.");
    }
}

void RemoverLivro()
{
    Console.Write("Digite o termo do livro que deseja remover: ");
    string busca = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(busca))
    {
        Console.WriteLine("Erro: O termo não pode ser vazio.");
        return;
    }

    string livroEncontrado = "";

    foreach (string livro in livros)
    {
        if (livro.ToLower().Contains(busca.ToLower()))
        {
            livroEncontrado = livro;
            break;
        }
    }

    if (livroEncontrado != "")
    {
        livros.Remove(livroEncontrado);
        Console.WriteLine($"Livro removido com sucesso: {livroEncontrado}");
    }
    else
    {
        Console.WriteLine("Livro não encontrado para remoção.");
    }
}