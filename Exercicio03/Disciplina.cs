public class Disciplina
{
    public string Nome { get; set; }
    public int Periodo { get; set; }
    public int CargaHoraria { get; set; }
    public string ProfessorResponsavel { get; set; }

    public Disciplina(string nome, int periodo, int cargaHoraria, string professorResponsavel)
    {
        Nome = nome;
        Periodo = periodo;
        CargaHoraria = cargaHoraria;
        ProfessorResponsavel = professorResponsavel;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Periodo: {Periodo}");
        Console.WriteLine($"Carga horaria: {CargaHoraria}");
        Console.WriteLine($"Professor responsavel: {ProfessorResponsavel}");
    }
}
