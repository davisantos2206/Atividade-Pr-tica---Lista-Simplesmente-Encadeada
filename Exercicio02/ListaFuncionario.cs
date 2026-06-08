public class ListaFuncionario
{
    private NoFuncionario? inicio;
    private NoFuncionario? fim;

    public bool EstaVazia()
    {
        return inicio == null && fim == null;
    }

    public void InserirInicio(Funcionario funcionario)
    {
        NoFuncionario novoNo = new NoFuncionario(funcionario);

        if (EstaVazia())
        {
            inicio = novoNo;
            fim = novoNo;
            return;
        }

        novoNo.Proximo = inicio;
        inicio = novoNo;
    }

    public void InserirFim(Funcionario funcionario)
    {
        NoFuncionario novoNo = new NoFuncionario(funcionario);

        if (EstaVazia())
        {
            inicio = novoNo;
            fim = novoNo;
            return;
        }

        fim!.Proximo = novoNo;
        fim = novoNo;
    }

    public Funcionario? BuscarPorNome(string nome)
    {
        NoFuncionario? atual = inicio;

        while (atual != null)
        {
            if (atual.Valor.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return atual.Valor;
            }

            atual = atual.Proximo;
        }

        return null;
    }

    public Funcionario? RemoverInicio()
    {
        if (EstaVazia())
        {
            return null;
        }

        Funcionario removido = inicio!.Valor;
        inicio = inicio.Proximo;

        if (inicio == null)
        {
            fim = null;
        }

        return removido;
    }

    public Funcionario? RemoverFim()
    {
        if (EstaVazia())
        {
            return null;
        }

        Funcionario removido = fim!.Valor;

        if (inicio == fim)
        {
            inicio = null;
            fim = null;
            return removido;
        }

        NoFuncionario atual = inicio!;
        while (atual.Proximo != fim)
        {
            atual = atual.Proximo!;
        }

        atual.Proximo = null;
        fim = atual;
        return removido;
    }

    public void Percurso()
    {
        if (EstaVazia())
        {
            Console.WriteLine("Lista vazia.");
            return;
        }

        NoFuncionario? atual = inicio;
        int posicao = 1;

        while (atual != null)
        {
            Console.WriteLine($"Funcionario {posicao}");
            atual.Valor.Imprimir();
            Console.WriteLine();
            atual = atual.Proximo;
            posicao++;
        }
    }
}
