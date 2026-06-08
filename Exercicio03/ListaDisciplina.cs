public class ListaDisciplina
{
    private NoDisciplina? inicio;

    public bool EstaVazia()
    {
        return inicio == null;
    }

    public void InserirOrdenado(Disciplina disciplina)
    {
        NoDisciplina novoNo = new NoDisciplina(disciplina);

        if (EstaVazia() || CompararNomes(disciplina.Nome, inicio!.Valor.Nome) <= 0)
        {
            novoNo.Proximo = inicio;
            inicio = novoNo;
            return;
        }

        NoDisciplina atual = inicio!;
        while (atual.Proximo != null && CompararNomes(disciplina.Nome, atual.Proximo.Valor.Nome) > 0)
        {
            atual = atual.Proximo;
        }

        novoNo.Proximo = atual.Proximo;
        atual.Proximo = novoNo;
    }

    public Disciplina? BuscarPorNome(string nome)
    {
        NoDisciplina? atual = inicio;

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

    public Disciplina? RemoverPorNome(string nome)
    {
        if (EstaVazia())
        {
            return null;
        }

        if (inicio!.Valor.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
        {
            Disciplina removida = inicio.Valor;
            inicio = inicio.Proximo;
            return removida;
        }

        NoDisciplina atual = inicio;
        while (atual.Proximo != null && !atual.Proximo.Valor.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
        {
            atual = atual.Proximo;
        }

        if (atual.Proximo == null)
        {
            return null;
        }

        Disciplina disciplinaRemovida = atual.Proximo.Valor;
        atual.Proximo = atual.Proximo.Proximo;
        return disciplinaRemovida;
    }

    public void Percurso()
    {
        if (EstaVazia())
        {
            Console.WriteLine("Lista vazia.");
            return;
        }

        NoDisciplina? atual = inicio;
        int posicao = 1;

        while (atual != null)
        {
            Console.WriteLine($"Disciplina {posicao}");
            atual.Valor.Imprimir();
            Console.WriteLine();
            atual = atual.Proximo;
            posicao++;
        }
    }

    private static int CompararNomes(string primeiroNome, string segundoNome)
    {
        return string.Compare(primeiroNome, segundoNome, StringComparison.OrdinalIgnoreCase);
    }
}
