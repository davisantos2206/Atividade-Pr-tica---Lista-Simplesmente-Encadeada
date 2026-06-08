Lista lista = new Lista();
int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("Exercicio 1 - Lista Simplesmente Encadeada");
    Console.WriteLine("1 - Inserir no inicio");
    Console.WriteLine("2 - Inserir no fim");
    Console.WriteLine("3 - Remover do inicio");
    Console.WriteLine("4 - Remover do fim");
    Console.WriteLine("5 - Buscar valor");
    Console.WriteLine("6 - Mostrar lista");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            lista.InserirInicio(LerInteiro("Valor: "));
            Console.WriteLine("Valor inserido no inicio.");
            break;
        case 2:
            lista.InserirFim(LerInteiro("Valor: "));
            Console.WriteLine("Valor inserido no fim.");
            break;
        case 3:
            MostrarRemocao(lista.RemoverInicio());
            break;
        case 4:
            MostrarRemocao(lista.RemoverFim());
            break;
        case 5:
            int valorBusca = LerInteiro("Valor para buscar: ");
            Console.WriteLine(lista.Buscar(valorBusca) ? "Valor encontrado." : "Valor nao encontrado.");
            break;
        case 6:
            lista.Percurso();
            break;
        case 0:
            Console.WriteLine("Encerrando...");
            break;
        default:
            Console.WriteLine("Opcao invalida.");
            break;
    }
} while (opcao != 0);

static int LerInteiro(string mensagem)
{
    int valor;

    do
    {
        Console.Write(mensagem);
    } while (!int.TryParse(Console.ReadLine(), out valor));

    return valor;
}

static void MostrarRemocao(int? valor)
{
    Console.WriteLine(valor.HasValue ? $"Valor removido: {valor.Value}" : "Lista vazia.");
}
