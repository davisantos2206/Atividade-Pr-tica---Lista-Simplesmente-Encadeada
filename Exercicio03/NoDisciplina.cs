public class NoDisciplina
{
    public Disciplina Valor { get; set; }
    public NoDisciplina? Proximo { get; set; }

    public NoDisciplina(Disciplina valor)
    {
        Valor = valor;
        Proximo = null;
    }
}
