using BibliotecaCLI.Services;

LivroService livroService = new();

bool executando = true;

while (executando)
{
    Console.WriteLine("\n===== SISTEMA DE BIBLIOTECA POO =====");
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Listar Livros");
    Console.WriteLine("3 - Buscar Livro");
    Console.WriteLine("4 - Remover Livro");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção: ");

    if (!int.TryParse(Console.ReadLine(), out int opcao))
    {
        continue;
    }

    switch (opcao)
    {
        case 1:
            livroService.CadastrarLivro();
            break;

        case 2:
            livroService.ListarLivros();
            break;

        case 3:
            livroService.BuscarLivro();
            break;

        case 4:
            livroService.RemoverLivro();
            break;

        case 5:
            executando = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}