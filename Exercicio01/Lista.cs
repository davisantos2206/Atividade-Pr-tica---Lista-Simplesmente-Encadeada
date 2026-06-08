public class Lista
{
    private No? inicio;
    private No? fim;

    public bool EstaVazia()
    {
        return inicio == null && fim == null;
    }

    public void InserirInicio(int valor)
    {
        No novoNo = new No(valor);

        if (EstaVazia())
        {
            inicio = novoNo;
            fim = novoNo;
            return;
        }

        novoNo.Proximo = inicio;
        inicio = novoNo;
    }

    public void InserirFim(int valor)
    {
        No novoNo = new No(valor);

        if (EstaVazia())
        {
            inicio = novoNo;
            fim = novoNo;
            return;
        }

        fim!.Proximo = novoNo;
        fim = novoNo;
    }

    public int? RemoverInicio()
    {
        if (EstaVazia())
        {
            return null;
        }

        int valorRemovido = inicio!.Valor;
        inicio = inicio.Proximo;

        if (inicio == null)
        {
            fim = null;
        }

        return valorRemovido;
    }

    public int? RemoverFim()
    {
        if (EstaVazia())
        {
            return null;
        }

        int valorRemovido = fim!.Valor;

        if (inicio == fim)
        {
            inicio = null;
            fim = null;
            return valorRemovido;
        }

        No atual = inicio!;
        while (atual.Proximo != fim)
        {
            atual = atual.Proximo!;
        }

        atual.Proximo = null;
        fim = atual;
        return valorRemovido;
    }

    public bool Buscar(int valor)
    {
        No? atual = inicio;

        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                return true;
            }

            atual = atual.Proximo;
        }

        return false;
    }

    public void Percurso()
    {
        if (EstaVazia())
        {
            Console.WriteLine("Lista vazia.");
            return;
        }

        No? atual = inicio;

        while (atual != null)
        {
            Console.Write($"{atual.Valor}");
            atual = atual.Proximo;
            Console.Write(atual == null ? Environment.NewLine : " -> ");
        }
    }
}
