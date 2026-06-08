public class No
{
    public int Valor { get; set; }
    public No? Proximo { get; set; }

    public No(int valor)
    {
        Valor = valor;
        Proximo = null;
    }
}
