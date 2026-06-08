public class NoFuncionario
{
    public Funcionario Valor { get; set; }
    public NoFuncionario? Proximo { get; set; }

    public NoFuncionario(Funcionario valor)
    {
        Valor = valor;
        Proximo = null;
    }
}
