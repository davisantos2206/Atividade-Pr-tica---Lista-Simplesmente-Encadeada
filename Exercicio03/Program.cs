ListaDisciplina lista = new ListaDisciplina();
int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("Exercicio 3 - Lista de Disciplinas");
    Console.WriteLine("1 - Inserir disciplina em ordem por nome");
    Console.WriteLine("2 - Buscar disciplina por nome");
    Console.WriteLine("3 - Remover disciplina por nome");
    Console.WriteLine("4 - Mostrar disciplinas");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            lista.InserirOrdenado(LerDisciplina());
            Console.WriteLine("Disciplina inserida em ordem.");
            break;
        case 2:
            Console.Write("Nome da disciplina para buscar: ");
            Disciplina? encontrada = lista.BuscarPorNome(Console.ReadLine() ?? string.Empty);
            if (encontrada == null)
            {
                Console.WriteLine("Disciplina nao encontrada.");
            }
            else
            {
                Console.WriteLine("Disciplina encontrada:");
                encontrada.Imprimir();
            }
            break;
        case 3:
            Console.Write("Nome da disciplina para remover: ");
            Disciplina? removida = lista.RemoverPorNome(Console.ReadLine() ?? string.Empty);
            if (removida == null)
            {
                Console.WriteLine("Disciplina nao encontrada.");
            }
            else
            {
                Console.WriteLine("Disciplina removida:");
                removida.Imprimir();
            }
            break;
        case 4:
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

static Disciplina LerDisciplina()
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine() ?? string.Empty;

    int periodo = LerInteiro("Periodo: ");
    int cargaHoraria = LerInteiro("Carga horaria: ");

    Console.Write("Professor responsavel: ");
    string professorResponsavel = Console.ReadLine() ?? string.Empty;

    return new Disciplina(nome, periodo, cargaHoraria, professorResponsavel);
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
