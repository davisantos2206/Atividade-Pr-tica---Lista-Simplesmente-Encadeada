ListaFuncionario lista = new ListaFuncionario();
int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("Exercicio 2 - Lista de Funcionarios");
    Console.WriteLine("1 - Inserir funcionario no inicio");
    Console.WriteLine("2 - Inserir funcionario no fim");
    Console.WriteLine("3 - Buscar funcionario por nome");
    Console.WriteLine("4 - Remover funcionario do inicio");
    Console.WriteLine("5 - Remover funcionario do fim");
    Console.WriteLine("6 - Mostrar funcionarios");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            lista.InserirInicio(LerFuncionario());
            Console.WriteLine("Funcionario inserido no inicio.");
            break;
        case 2:
            lista.InserirFim(LerFuncionario());
            Console.WriteLine("Funcionario inserido no fim.");
            break;
        case 3:
            Console.Write("Nome para buscar: ");
            Funcionario? encontrado = lista.BuscarPorNome(Console.ReadLine() ?? string.Empty);
            if (encontrado == null)
            {
                Console.WriteLine("Funcionario nao encontrado.");
            }
            else
            {
                Console.WriteLine("Funcionario encontrado:");
                encontrado.Imprimir();
            }
            break;
        case 4:
            MostrarRemocao(lista.RemoverInicio());
            break;
        case 5:
            MostrarRemocao(lista.RemoverFim());
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

static Funcionario LerFuncionario()
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine() ?? string.Empty;

    int idade = LerInteiro("Idade: ");

    Console.Write("Telefone: ");
    string telefone = Console.ReadLine() ?? string.Empty;

    decimal salario = LerDecimal("Salario: ");

    return new Funcionario(nome, idade, telefone, salario);
}

static int LerInteiro(string mensagem)
{
    int valor;

    do
    {
        Console.Write(mensagem);
    } while (!int.TryParse(Console.ReadLine(), out valor));

    return valor;
}

static decimal LerDecimal(string mensagem)
{
    decimal valor;

    do
    {
        Console.Write(mensagem);
    } while (!decimal.TryParse(Console.ReadLine(), out valor));

    return valor;
}

static void MostrarRemocao(Funcionario? funcionario)
{
    if (funcionario == null)
    {
        Console.WriteLine("Lista vazia.");
        return;
    }

    Console.WriteLine("Funcionario removido:");
    funcionario.Imprimir();
}
